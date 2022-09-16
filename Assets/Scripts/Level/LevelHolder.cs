using System;
using System.Collections.Generic;
using Hero;
using Interations;
using UnityEngine;

namespace Level
{
    public class LevelHolder : MonoBehaviour
    {
        [SerializeField] private PlayerCollisionHandler _playerCollisionHandler;
        [SerializeField] private List<Coin> _coins;

        public event Action LevelCompleted;

        private void OnEnable()
        {
            _playerCollisionHandler.CoinPickedUp += OnCoinPickedUp;
        }

        private void OnDisable()
        {
            _playerCollisionHandler.CoinPickedUp -= OnCoinPickedUp;
        }

        private void OnCoinPickedUp(Coin coin)
        {
            if (_coins.Count > 0 && _coins != null)
            {
                _coins.Remove(coin);

                if (_coins.Count <= 0)
                {
                    LevelEnd();
                }
            }
        }

        private void LevelEnd()
        {
            LevelCompleted?.Invoke();
            print("Level Complete");
        }
    }
}