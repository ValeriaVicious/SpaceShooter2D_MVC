using System;
using System.Collections.Generic;
using UnityEngine;


namespace TheRetroSpaceShooter
{
    internal sealed class ControllersHandler : IExecute, IInitialization, ICleanup, ILateExecute, IFixedExecute
    {
        #region Fields

        private readonly List<IInitialization> _initializationControllers;
        private readonly List<IExecute> _executeControllers;
        private readonly List<ICleanup> _cleanupControllers;
        private readonly List<ILateExecute> _lateExecuteControllers;
        private readonly List<IFixedExecute> _fixedExecuteControllers;

        #endregion


        #region ClassLifeCycles

        public ControllersHandler()
        {
            _initializationControllers = new List<IInitialization>();
            _executeControllers = new List<IExecute>();
            _cleanupControllers = new List<ICleanup>();
            _fixedExecuteControllers = new List<IFixedExecute>();
            _lateExecuteControllers = new List<ILateExecute>();
        }

        #endregion


        #region Methods

        public void Cleanup()
        {
            for (int i = 0; i < _cleanupControllers.Count; i++)
            {
                _cleanupControllers[i].Cleanup();
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < _executeControllers.Count; i++)
            {
                _executeControllers[i].Execute(Time.deltaTime);
            }
        }

        public void FixedExecute(float deltaTime)
        {
            for (int i = 0; i < _fixedExecuteControllers.Count; i++)
            {
                _fixedExecuteControllers[i].FixedExecute(Time.deltaTime);
            }
        }

        public void Initialization()
        {
            for (int i = 0; i < _initializationControllers.Count; i++)
            {
                _initializationControllers[i].Initialization();
            }
        }

        public void LateExecute(float deltaTime)
        {
            for (int i = 0; i < _lateExecuteControllers.Count; i++)
            {
                _lateExecuteControllers[i].LateExecute(Time.deltaTime);
            }
        }

        internal void Add(IController controller)
        {
            if (controller is IInitialization initialization)
            {
                _initializationControllers.Add(initialization);
            }
            if (controller is IExecute execute)
            {
                _executeControllers.Add(execute);
            }
            if (controller is ILateExecute lateExecute)
            {
                _lateExecuteControllers.Add(lateExecute);
            }
            if (controller is ICleanup cleanup)
            {
                _cleanupControllers.Add(cleanup);
            }
            if (controller is IFixedExecute fixedExecute)
            {
                _fixedExecuteControllers.Add(fixedExecute);
            }
        }

        #endregion
    }
}
