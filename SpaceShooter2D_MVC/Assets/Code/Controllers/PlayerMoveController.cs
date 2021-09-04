

namespace TheRetroSpaceShooter
{
    internal sealed class PlayerMoveController : IExecute, ICleanup
    {
        #region Fields

        private readonly IMoveSpaceShip _moveSpaceShip;
        private IUserInputProxy _horizontalInputProxy;
        private IUserInputProxy _verticalInputProxy;
        private float _horizontal;
        private float _vertical;

        #endregion


        #region ClassLifeCycles

        public PlayerMoveController((IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) input,
            IMoveSpaceShip moveSpaceShip)
        {
            _moveSpaceShip = moveSpaceShip;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.AxisOnChangeEvent += HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChangeEvent += VerticalOnAxisChange;
        }

        #endregion


        #region Methods

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChangeEvent -= HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChangeEvent -= VerticalOnAxisChange;
        }

        public void Execute(float deltaTime)
        {
            _moveSpaceShip.Move(_horizontal, _vertical, deltaTime);
        }

        private void HorizontalOnAxisChange(float value)
        {
            _horizontal = value;
        }

        private void VerticalOnAxisChange(float value)
        {
            _vertical = value;
        }

        #endregion
    }
}
