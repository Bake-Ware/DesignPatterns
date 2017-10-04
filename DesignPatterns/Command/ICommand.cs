namespace DesignPatterns.Command
{
    public interface ICommand
    {
        string Message { get; set; }
        string Values { get; set; }
        void Execute();
        void Unexecute();
    }
}
