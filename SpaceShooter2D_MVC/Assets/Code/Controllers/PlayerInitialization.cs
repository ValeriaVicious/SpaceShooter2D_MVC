﻿using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class PlayerInitialization : IInitialization
    {
        #region Fields

        private Player _player;
        private IMoveSpaceShip _moveSpaceShip;

        #endregion


        #region Properties

        public Player GetPlayer => _player;
        public IMoveSpaceShip GetMoveShip => _moveSpaceShip;

        #endregion


        #region ClassLifeCycles

        public PlayerInitialization(PlayerConfig playerConfig)
        {
            _player = Object.Instantiate(playerConfig.PlayerPrefab);
            _moveSpaceShip = new MoveTransformOfPlayer(_player.transform, playerConfig.Speed);
        }

        #endregion


        #region Methods

        public void Initialization() { }

        #endregion
    }
}
