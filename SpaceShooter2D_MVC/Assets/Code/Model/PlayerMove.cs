

namespace TheRetroSpaceShooter
{
    internal sealed class PlayerMove : IMoveSpaceShip
    {
        #region Fields

        private readonly IMoveSpaceShip _moveSpaceShip;

        #endregion


        #region Properties

        public float Speed => _moveSpaceShip.Speed;

        #endregion


        #region ClassLifeCycles

        public PlayerMove(IMoveSpaceShip moveSpaceShip)
        {
            _moveSpaceShip = moveSpaceShip;
        }

        #endregion


        #region Methods

        public void Move(float horizontal, float deltaTime)
        {
            _moveSpaceShip.Move(horizontal, deltaTime);
        }

        #endregion
    }
}
