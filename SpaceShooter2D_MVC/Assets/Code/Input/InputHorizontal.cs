using UnityEngine;
using System;


namespace TheRetroSpaceShooter
{
    internal sealed class InputHorizontal : IUserInputProxy
    {
        #region Fields

        public event Action<float> AxisOnChangeEvent =
            delegate (float changeOfDirection) { };

        #endregion


        #region Methods

        public void GetAxis()
        {
            AxisOnChangeEvent.Invoke(Input.GetAxis(Constants.HorizontalInput));
        }

        #endregion
    }
}
