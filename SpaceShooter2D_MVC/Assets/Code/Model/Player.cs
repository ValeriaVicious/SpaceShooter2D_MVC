using System;
using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class Player : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Transform _barrelTransform;

        public Action<GameObject> OnCollisionEnterChange;

        #endregion


        #region Properties

        public Transform BarrelTransform => _barrelTransform;

        #endregion


        #region UnityMethods

        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnCollisionEnterChange?.Invoke(collision.gameObject);
        }

        #endregion
    }
}
