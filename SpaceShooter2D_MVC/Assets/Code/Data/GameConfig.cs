using UnityEngine;


namespace TheRetroSpaceShooter
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig", order = 0)]
    public sealed class GameConfig : ScriptableObject
    {
        #region Fields

        [SerializeField] private PlayerConfig _playerConfig;

        #endregion


        #region Properties

        public PlayerConfig PlayerConfig => _playerConfig;

        #endregion
    }
}
