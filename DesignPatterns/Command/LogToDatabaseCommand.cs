using System;

namespace DesignPatterns.Command
{
    class LogToDatabaseCommand : ICommand
    {
        public string Message { get; set; }
        public string Values { get; set; }
        public LogToDatabaseCommand(string message, string values)
        {
            Message = message;
            Values = values;
        }
        
        public void Execute()
        {
            Console.WriteLine("Write to database: {0} - {1}",Message,Values);
        }

        public void Unexecute()
        {
            Console.WriteLine("Delete from database: {0} - {1}", Message, Values);
        }
    }
}
