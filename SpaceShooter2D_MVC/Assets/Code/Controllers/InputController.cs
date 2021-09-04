using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class InputController : IExecute
    {
        #region Fields

        private readonly IUserInputProxy _inputHorizontal;

        #endregion


        #region ClassLifeCycles

        public InputController(IUserInputProxy horizontalInput)
        {
            _inputHorizontal = horizontalInput;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _inputHorizontal.GetAxis();
        }

        #endregion
    }
}
