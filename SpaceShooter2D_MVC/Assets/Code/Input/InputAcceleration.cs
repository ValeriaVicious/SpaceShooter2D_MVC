using System;
using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class InputAcceleration : IUserAccelerationProxy
    {
        public event Action<bool> AxisOnChangeEvent = 
            delegate (bool  isChangeOfSpeed) { };

        public void GetAxis()
        {
            AxisOnChangeEvent.Invoke(Input.GetKeyDown(KeyCode.LeftShift));
        }
    }
}
