using System;
using UnityEngine;

namespace Hero
{
    public class PlayerCollisionHandler : MonoBehaviour
    {
        [SerializeField] private PlayerWallet _playerWallet;

        public event Action<Coin> CoinPickedUp;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Coin coin))
            {
                _playerWallet.AddMoney(coin.Value);
                CoinPickedUp?.Invoke(coin);
            }
        }
    }
}