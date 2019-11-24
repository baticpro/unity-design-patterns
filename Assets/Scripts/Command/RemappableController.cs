using Command.InputCommands;
using UnityEngine;

namespace Command
{
    public class RemappableController: MonoBehaviour
    {
        private PlayerMoving _playerMoving;

        private IInputCommand _leftCommand;
        private IInputCommand _rightCommand;
        private IInputCommand _jumpCommand;

        private void Awake()
        {
            _playerMoving = FindObjectOfType<PlayerMoving>();
            
            SetInputs();
        }

        private void SetInputs()
        {
            _leftCommand = new LeftCommand();
            _rightCommand = new RightCommand();
            _jumpCommand = new JumpCommand();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _leftCommand.Execute(_playerMoving);
            }else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _rightCommand.Execute(_playerMoving);
            }else if (Input.GetKeyDown(KeyCode.Space))
            {
                _jumpCommand.Execute(_playerMoving);
            }
        }
    }
}