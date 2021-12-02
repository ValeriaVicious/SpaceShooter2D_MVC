

namespace TheRetroSpaceShooter
{
    internal sealed class CharacterInitialization
    {
        public CharacterInitialization(ControllersHandler controllersHandler,
            GameConfig gameConfig)
        {
            var playerInitialization = new PlayerInitialization(gameConfig.PlayerConfig);
            var inputInitialization = new InputInitialization();
            var inputAcceleration = new InputAcceleration();
            controllersHandler.Add(playerInitialization);
            controllersHandler.Add(new PlayerMoveController(inputInitialization.GetInput(),
                playerInitialization.GetMoveShip, inputInitialization.GetAcceleration()));
            controllersHandler.Add(new InputController(inputInitialization.GetInput(),
                inputInitialization.GetAcceleration()));
        }
    }
}
