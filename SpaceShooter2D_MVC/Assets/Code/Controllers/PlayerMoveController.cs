

namespace TheRetroSpaceShooter
{
    internal sealed class PlayerMoveController : IExecute, ICleanup
    {
        #region Fields

        private readonly IMoveSpaceShip _moveSpaceShip;
        private IUserInputProxy _horizontalInputProxy;
        private float _horizontal;

        #endregion


        #region ClassLifeCycles

        public PlayerMoveController(IUserInputProxy inputHorizontal,
            IMoveSpaceShip moveSpaceShip)
        {
            _moveSpaceShip = moveSpaceShip;
            _horizontalInputProxy = inputHorizontal;
            _horizontalInputProxy.AxisOnChangeEvent += HorizontalOnAxisChange;
        }

        #endregion


        #region Methods

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChangeEvent -= HorizontalOnAxisChange;
        }

        public void Execute(float deltaTime)
        {
            _moveSpaceShip.Move(_horizontal, deltaTime);
        }

        private void HorizontalOnAxisChange(float value)
        {
            _horizontal = value;
        }

        #endregion
    }
}
