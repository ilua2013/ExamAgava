using System;
using System.Collections.Generic;
using Interactions;
using UnityEngine;

namespace Level
{
    public class LevelHolder : MonoBehaviour
    {
        [SerializeField] private List<Coin> _coins;

        private void OnEnable()
        {
            foreach (var coin in _coins)
            {
                coin.Taked += OnCoinPickedUp;
            }
        }

        private void OnDisable()
        {
            foreach (var coin in _coins)
            {
                coin.Taked -= OnCoinPickedUp;
            }
        }

        private void OnValidate()
        {
            _coins = new List<Coin>(FindObjectsOfType<Coin>());
        }

        public event Action LevelCompleted;

        private void OnCoinPickedUp(Coin coin)
        {
            if (_coins.Count > 0 && _coins != null && _coins.Contains(coin))
            {
                _coins.Remove(coin);

                if (_coins.Count <= 0)
                {
                    CompleteLevel();
                }
            }
        }

        private void CompleteLevel()
        {
            LevelCompleted?.Invoke();
            print("Level Complete");
        }
    }
}