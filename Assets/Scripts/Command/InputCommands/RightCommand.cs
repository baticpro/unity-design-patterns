namespace Command.InputCommands
{
    public class RightCommand: IInputCommand
    {
        public void Execute(PlayerMoving playerMoving)
        {
            playerMoving.GoRight();
        }
    }
}