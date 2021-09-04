using System;


namespace TheRetroSpaceShooter
{
    public interface IUserInputProxy
    {
        public event Action<float> AxisOnChangeEvent;
        public void GetAxis();
    }
}
