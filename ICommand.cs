namespace ConsoleApp
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

}
