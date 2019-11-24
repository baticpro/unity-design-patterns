namespace Command.InputCommands
{
    public class LeftCommand: IInputCommand
    {
        public void Execute(PlayerMoving playerMoving)
        {
            playerMoving.GoLeft();
        }
    }
}