

namespace TheRetroSpaceShooter
{
    internal sealed class InputInitialization : IInitialization
    {
        #region Fields

        private IUserInputProxy _horizontalInput;

        #endregion


        #region ClassLifeCycles

        public InputInitialization()
        {
            _horizontalInput = new InputHorizontal();
        }

        #endregion


        #region Methods

        public void Initialization()
        {

        }

        public IUserInputProxy GetInput()
        {
            var result = _horizontalInput;
            return result;
        }

        #endregion
    }
}
