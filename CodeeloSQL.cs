using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DesktopCalendar
{
    class CodeeloSQL
    {
        public static readonly string CONNECTION_STRING = @"Data Source = " + Environment.CurrentDirectory
            + @"\Calendar.db; Version=3;";
        private static SQLiteConnection _connection;
        private static SQLiteCommand _command;

        public static List<Appointment> GetAppointments(DateTime date)
        {
            var appointments = new List<Appointment>();
            var patterns = new List<RecurrencePattern>();
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = $"Select * from Appointments where EndDate like '{date.ToString("yyyy-MM-dd")}'";
                var reader = _command.ExecuteReader();
                while(reader.Read())
                {
                    var appointment = new Appointment();

                    appointment.ID = int.Parse(reader["ID"].ToString());
                    appointment.Title = reader["Title"].ToString();
                    appointment.Description = reader["Description"].ToString();
                    appointment.EndDate = Convert.ToDateTime(reader["EndDate"].ToString());
                    appointment.IsCompleted = Convert.ToBoolean(reader["IsCompleted"]);
                    appointment.Result = reader["Result"].ToString();
                    appointments.Add(appointment);
                }
                reader.Close();
            }
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = $"Select * from RecurrenceInfo";
                var reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    var pattern = new RecurrencePattern();

                    pattern.ID = int.Parse(reader["ID"].ToString());
                    pattern.Title = reader["Title"].ToString();
                    pattern.Description = reader["Description"].ToString();
                    pattern.StartDate = Convert.ToDateTime(reader["StartDate"].ToString());
                    pattern.HasEnd = Convert.ToBoolean(reader["HasEnd"]);
                    if(pattern.HasEnd)
                    {
                        pattern.EndDate = Convert.ToDateTime(reader["EndDate"].ToString());
                        pattern.RecurrenceCount = int.Parse(reader["RecurrenceCount"].ToString());
                    }
                    pattern.PeriodID = int.Parse(reader["PeriodID"].ToString());
                    pattern.PeriodValue = int.Parse(reader["PeriodValue"].ToString());

                    patterns.Add(pattern);
                }
                reader.Close();
            }
            if (patterns.Count > 0)
                appointments.Where(x => x.RecurrenceID > 0).ToList().ForEach(x => 
                {
                    patterns.RemoveAt(patterns.FindIndex(y => y.ID == x.RecurrenceID));
                });
            foreach (var item in patterns)
            {
                if (item.StartDate > date)
                    continue;
                if(item.HasEnd)
                {
                    if(item.RecurrenceCount > 0)
                    {
                        while (item.RecurrenceCount > 1)
                        {
                            ChechDateEquals(item);
                            item.RecurrenceCount--;

                            if(item.StartDate == date)
                            {
                                var appointment = new Appointment()
                                {
                                    Title = item.Title,
                                    Description = item.Description,
                                    EndDate = date,
                                    IsCompleted = false,
                                    RecurrenceID = item.ID
                                };
                                appointments.Add(appointment);
                                break;
                            }
                        }
                    }
                    if(item.EndDate > DateTime.Now)
                    {
                        while (item.EndDate > item.StartDate)
                        {
                            ChechDateEquals(item);
                            if(item.StartDate == date)
                            {
                                var appointment = new Appointment()
                                {
                                    Title = item.Title,
                                    Description = item.Description,
                                    EndDate = date,
                                    IsCompleted = false,
                                    RecurrenceID = item.ID
                                };
                                appointments.Add(appointment);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    while(date > item.StartDate)
                    {
                        ChechDateEquals(item);
                        if(item.StartDate == date)
                        {
                            var appointment = new Appointment()
                            {
                                Title = item.Title,
                                Description = item.Description,
                                EndDate = date,
                                IsCompleted = false,
                                RecurrenceID = item.ID
                            };
                            appointments.Add(appointment);
                            break;
                        }
                    }
                }
            }
            return appointments;
        }
        private static void ChechDateEquals(RecurrencePattern item)
        {
            //if or switch, choose
            if(item.PeriodID == 1)
            {
                item.StartDate = item.StartDate.AddDays(item.PeriodValue);
            }
            if (item.PeriodID == 2)
            {
                item.StartDate = item.StartDate.AddDays(7*item.PeriodValue);
            }
            if (item.PeriodID == 3)
            {
                item.StartDate = item.StartDate.AddMonths(item.PeriodValue);
            }
            if (item.PeriodID == 4)
            {
                item.StartDate = item.StartDate.AddYears(item.PeriodValue);
            }
        }
        public static void AddAppointment(Appointment appointment)
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                if(appointment.RecurrenceID > 0)
                {
                    _command.CommandText = "Insert into Appointments(Title,Description,EndDate,IsCompleted)" +
                    $"values('{appointment.Title}','{appointment.Description}','{appointment.EndDate.ToString("yyyy-MM-dd")}',0,{appointment.RecurrenceID})";
                }
                else
                {
                    _command.CommandText = "Insert into Appointments(Title,Description,EndDate,IsCompleted)" +
                    $"values('{appointment.Title}','{appointment.Description}','{appointment.EndDate.ToString("yyyy-MM-dd")}',0)";
                }
                
                _command.ExecuteNonQuery();
            }
        }

        public static void AddRecurrenceInfo(Appointment appointment, RecurrenceTemplate recurrence)
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                int hasEnd = recurrence.HasEnd ? 1 : 0;
                _command.CommandText = "Insert into RecurrenceInfo(Title,Description,EndDate,HasEnd, StartDate," +
                    "PeriodID,RecurrenceCount,PeriodValue)" +
                    $"values('{appointment.Title}','{appointment.Description}','{recurrence.EndDate.ToString("yyyy-MM-dd")}',{hasEnd}," +
                    $"'{recurrence.StartDate.ToString("yyyy - MM - dd")}',{recurrence.PeriodID},{recurrence.RecurrenceCount},{recurrence.PeriodValue})";
                _command.ExecuteNonQuery();
            }
        }
        public static void UpdateAppointment(Appointment appointment)
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                if(appointment.IsCompleted)
                {
                    _command.CommandText = $"update Appointments set Title='{appointment.Title}',Description='{appointment.Description}'," +
                        $"EndDate='{appointment.EndDate.ToString("yyyy-MM-dd")}',IsCompleted=1, Result = '{appointment.Result}' where ID={appointment.ID}";
                }
                else
                {
                    _command.CommandText = $"update Appointments set Title='{appointment.Title}',Description='{appointment.Description}'," +
                        $"EndDate='{appointment.EndDate.ToString("yyyy-MM-dd")}' where ID={appointment.ID}";
                }
                
                _command.ExecuteNonQuery();
            }
        }

        public static void ExecuteQuery(string query)
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = query;
                _command.ExecuteNonQuery();
            }
        }
        public static int GetNextAppointmentID()
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = "select seq from sqlite_sequence where name like 'Appointments'";
                return (Convert.ToInt32(_command.ExecuteScalar()) + 1);
            }
        }
    }
}
