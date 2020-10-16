namespace command_alt
{
    public interface ICommand
    {
        void Do();
        void Undo();

        bool IsReversible();
    }
}

