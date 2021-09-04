using System;
using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class InputVertical : IUserInputProxy
    {
        public event Action<float> AxisOnChangeEvent =
            delegate (float changeOfDirection) { };

        public void GetAxis()
        {
            AxisOnChangeEvent.Invoke(Input.GetAxis(Constants.VerticalInput));
        }
    }
}
