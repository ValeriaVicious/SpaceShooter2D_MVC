

namespace TheRetroSpaceShooter
{
    public interface IMoveSpaceShip : IController
    {
        public float Speed { get; set; }
        public void Move(float horizontal, float vertical, float deltaTime);
    }
}
