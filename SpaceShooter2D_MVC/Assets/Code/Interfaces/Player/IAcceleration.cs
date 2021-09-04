

namespace TheRetroSpaceShooter
{
    public interface IAcceleration : IController
    {
        public float AccelerationSpeed { get; }
        public void GetAcceleration(float horizontal, float vertical, float deltaTime);
    }
}
