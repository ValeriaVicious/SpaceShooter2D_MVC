﻿

namespace TheRetroSpaceShooter
{
    internal sealed class InputInitialization : IInitialization
    {
        #region Fields

        private IUserInputProxy _horizontalInput;
        private IUserInputProxy _verticalInput;
        private IUserAccelerationProxy _accelerationProxy;

        #endregion


        #region ClassLifeCycles

        public InputInitialization()
        {
            _horizontalInput = new InputHorizontal();
            _verticalInput = new InputVertical();
            _accelerationProxy = new InputAcceleration();
        }

        #endregion


        #region Methods

        public void Initialization()
        {

        }

        public (IUserInputProxy horizontal, IUserInputProxy vertical) GetInput()
        {
            (IUserInputProxy horizontal, IUserInputProxy vertical) result = (_horizontalInput, _verticalInput);
            return result;
        }

        public IUserAccelerationProxy GetAcceleration()
        {
            return _accelerationProxy;
        }

        #endregion
    }
}
