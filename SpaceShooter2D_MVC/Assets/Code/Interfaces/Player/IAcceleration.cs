

namespace TheRetroSpaceShooter
{
    public interface IAcceleration : IController
    {
        public float Acceleration { get; set; }

        public void GetAcceleration(float horizontal, float vertical, float deltaTime);
    }
}
