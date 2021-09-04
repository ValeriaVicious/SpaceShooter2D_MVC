using System;
using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class CharacterInitialization
    {
        public CharacterInitialization(ControllersHandler controllersHandler,
            GameConfig gameConfig)
        {
            var playerInitialization = new PlayerInitialization(gameConfig.PlayerConfig);
            var inputInitialization = new InputInitialization();
            controllersHandler.Add(playerInitialization);
            controllersHandler.Add(new PlayerMoveController(inputInitialization.GetInput(),
                playerInitialization.GetMoveShip));
        }
    }
}
