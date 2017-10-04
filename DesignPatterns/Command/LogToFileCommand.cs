using System;

namespace DesignPatterns.Command
{
    class LogToFileCommand : ICommand
    {
        public string Message { get; set; }
        public string Values { get; set; }

        public LogToFileCommand(string message, string values)
        {
            Message = message;
            Values = values;
        }
        public void Execute()
        {
            Console.WriteLine("Write to file: {0} - {1}", Message, Values);
        }

        public void Unexecute()
        {
            Console.WriteLine("Delete from file: {0} - {1}", Message, Values);
        }
    }
}
