using UnityEngine;


namespace TheRetroSpaceShooter
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 0)]
    public sealed class PlayerConfig : ScriptableObject
    {
        #region Fields

        [SerializeField] private Player _playerPrefab;
        [SerializeField] private Rigidbody2D _rocketBody;
        [SerializeField] private Sprite _rocketSprite;
        [SerializeField] private float _speedOfPlayer;
        [SerializeField] private float _forceOfBullet;
        [SerializeField] private float _healthOfPlater;

        #endregion


        #region Properties

        internal Player PlayerPrefab => _playerPrefab;
        internal float Speed => _speedOfPlayer;

        #endregion
    }
}