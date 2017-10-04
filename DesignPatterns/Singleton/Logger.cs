using DesignPatterns.Command;

namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger _Logger = null; //This is the single instance we will use

        private Logger() //private constructor
        {
        }

        public static Logger GetInstance()
        {
            if(_Logger == null)
                _Logger = new Logger();
            return _Logger;
        }

        public void LogToFile(string message, string values)
        {
            new LogToFileCommand(message, values).Execute();
        }

        public void LogToDatabase(string message, string values)
        {
            new LogToDatabaseCommand(message, values).Execute();
        }

        public void LogToBoth(string message, string values)
        {
            new LogToFileCommand(message, values).Execute();
            new LogToDatabaseCommand(message, values).Execute();
        }

    }
}
