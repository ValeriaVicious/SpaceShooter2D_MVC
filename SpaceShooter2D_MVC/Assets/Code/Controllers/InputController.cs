using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class InputController : IExecute
    {
        #region Fields

        private readonly IUserInputProxy _inputHorizontal;
        private readonly IUserInputProxy _inputVertical;

        #endregion


        #region ClassLifeCycles

        public InputController((IUserInputProxy horizontalInput, 
            IUserInputProxy verticalInput)input)
        {
            _inputHorizontal = input.horizontalInput;
            _inputVertical = input.verticalInput;
    }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _inputHorizontal.GetAxis();
            _inputVertical.GetAxis();
        }

        #endregion
    }
}
