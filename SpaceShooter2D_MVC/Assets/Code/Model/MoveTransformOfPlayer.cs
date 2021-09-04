using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal class MoveTransformOfPlayer : IMoveSpaceShip
    {
        #region Fields

        private readonly Transform _transformOfPlayer;
        private Vector3 _moveVector;

        #endregion


        #region Properties

        public float Speed { get; protected set; }

        #endregion


        #region ClasslIfeCycles

        public MoveTransformOfPlayer(Transform transform, float speed)
        {
            _transformOfPlayer = transform;
            Speed = speed;
        }

        #endregion


        #region Methods

        public void Move(float horizontal, float deltaTime)
        {
            var speed = deltaTime * Speed;
            _moveVector.Set(horizontal * speed, 0.0f, 0.0f);
            _transformOfPlayer.localPosition += _moveVector;
        }

        #endregion
    }
}
