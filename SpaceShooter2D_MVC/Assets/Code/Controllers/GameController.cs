using System;
using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class GameController : MonoBehaviour, IDisposable
    {
        #region Fields

        [SerializeField] private GameConfig _gameConfig;
        private ControllersHandler _controllerHandler;
        private CharacterInitialization _playerInitialization;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _controllerHandler = new ControllersHandler();
            _playerInitialization = new CharacterInitialization(_controllerHandler, _gameConfig);
        }

        private void Start()
        {
            _controllerHandler.Initialization();
        }

        private void Update()
        {
            _controllerHandler.Execute(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _controllerHandler.FixedExecute(Time.deltaTime);
        }

        private void LateUpdate()
        {
            _controllerHandler.LateExecute(Time.deltaTime);
        }

        #endregion


        #region Methods

        public void Dispose()
        {
            _controllerHandler.Cleanup();
        }

        #endregion
    }
}
