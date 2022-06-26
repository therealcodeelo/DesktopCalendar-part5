namespace DesktopCalendar
{
    internal class Singleton
    {
        private static Singleton _instance;
        private MainForm _mainForm;
        public RecurrenceTemplate recurrenceTemplate;
        public static Singleton Instance
        {
            get 
            { 
                if(_instance == null)
                    _instance = new Singleton();
                return _instance; 
            }
        }
        public  MainForm MainForm
        {
            get
            {
                if(_mainForm == null || _mainForm.IsDisposed)
                    _mainForm = new MainForm();
                return _mainForm;
            }
        }
    }
}
