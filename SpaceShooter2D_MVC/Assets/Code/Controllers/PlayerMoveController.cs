

namespace TheRetroSpaceShooter
{
    internal sealed class PlayerMoveController : IExecute, ICleanup
    {
        #region Fields

        private readonly IMoveSpaceShip _moveSpaceShip;
        private IAcceleration _accelerationMove;
        private IUserInputProxy _horizontalInputProxy;
        private IUserInputProxy _verticalInputProxy;
        private IUserAccelerationProxy _accelerationProxy;
        private float _horizontal;
        private float _vertical;
        private bool _isAcceleration;

        #endregion


        #region ClassLifeCycles

        public PlayerMoveController((IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) input,
            IMoveSpaceShip moveSpaceShip, IUserAccelerationProxy inputAcceleration)
        {
            _moveSpaceShip = moveSpaceShip;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _accelerationProxy = inputAcceleration;

            _horizontalInputProxy.AxisOnChangeEvent += HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChangeEvent += VerticalOnAxisChange;
            _accelerationProxy.AxisOnChangeEvent += AccelerationOnAxisChange;
        }

        #endregion


        #region Methods

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChangeEvent -= HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChangeEvent -= VerticalOnAxisChange;
            _accelerationProxy.AxisOnChangeEvent -= AccelerationOnAxisChange;
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

        private void AccelerationOnAxisChange(bool isAcceleration)
        {
            _isAcceleration = isAcceleration;
        }

        #endregion
    }
}
