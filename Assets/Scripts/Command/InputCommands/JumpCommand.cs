namespace Command.InputCommands
{
    public class JumpCommand: IInputCommand
    {
        public void Execute(PlayerMoving playerMoving)
        {
            playerMoving.Jump();
        }
    }
}