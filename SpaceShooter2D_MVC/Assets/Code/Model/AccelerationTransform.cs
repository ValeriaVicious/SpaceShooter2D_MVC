using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class AccelerationTransform : IAcceleration
    {
        #region Fields

        private readonly Transform _transformOfPlayer;
        private Vector3 _moveVector;

        #endregion

        public float Speed { get; set; }
        public float Acceleration { get; set; }

        public AccelerationTransform(Transform transform, float acceleration,
            float speed)
        {
            _transformOfPlayer = transform;
            Acceleration = acceleration;
            Speed = speed;
        }

        public void GetAcceleration(float horizontal, float vertical, float deltaTime)
        {
            var speed = Speed + Acceleration * deltaTime;
            _moveVector.Set(horizontal * speed, vertical * speed, 0.0f);
            _transformOfPlayer.localPosition += _moveVector;
        }
    }
}
