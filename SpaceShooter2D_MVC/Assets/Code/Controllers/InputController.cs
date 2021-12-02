

namespace TheRetroSpaceShooter
{
    internal sealed class InputController : IExecute
    {
        #region Fields

        private readonly IUserInputProxy _inputHorizontal;
        private readonly IUserInputProxy _inputVertical;
        private readonly IUserAccelerationProxy _inputAcceleration;

        #endregion


        #region ClassLifeCycles

        public InputController((IUserInputProxy horizontalInput, 
            IUserInputProxy verticalInput)input, IUserAccelerationProxy acceleration)
        {
            _inputHorizontal = input.horizontalInput;
            _inputVertical = input.verticalInput;
            _inputAcceleration = acceleration;
    }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _inputHorizontal.GetAxis();
            _inputVertical.GetAxis();
            _inputAcceleration.GetAxis();
        }

        #endregion
    }
}
