

namespace TheRetroSpaceShooter
{
    internal sealed class PlayerMove : IMoveSpaceShip, IAcceleration
    {
        #region Fields

        private readonly IMoveSpaceShip _moveSpaceShip;
        private readonly IAcceleration _acceleration;

        #endregion


        #region Properties

        public float Speed
        {
            get
            {
                return _moveSpaceShip.Speed;
            }
            set
            {
                _moveSpaceShip.Speed = value;
            }
        }

        float IAcceleration.Acceleration { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        #endregion


        #region ClassLifeCycles

        public PlayerMove(IMoveSpaceShip moveSpaceShip, IAcceleration acceleration)
        {
            _moveSpaceShip = moveSpaceShip;
            _acceleration = acceleration;
        }

        #endregion


        #region Methods

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveSpaceShip.Move(horizontal, vertical, deltaTime);
        }

        public void GetAcceleration(float horizontal, float vertical, float deltaTime)
        {
            _acceleration.GetAcceleration(horizontal, vertical, deltaTime);
        }

        #endregion
    }
}
