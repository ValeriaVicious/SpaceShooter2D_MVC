using System;


namespace TheRetroSpaceShooter
{
    public interface IUserAccelerationProxy
    {
        public event Action<bool> AxisOnChangeEvent;
        public void GetAxis();
    }
}
