using System;
using UnityEngine;

namespace Hero
{
    [RequireComponent(typeof(Player))]
    public class PlayerCollisionHandler : MonoBehaviour
    {
        private Player _player;

        public event Action<Coin> CoinPickedUp;

        private void Awake()
        {
            _player = GetComponent<Player>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Coin coin))
            {
                _player.AddToWallet(coin.Value);
                CoinPickedUp?.Invoke(coin);
            }
        }
    }
}