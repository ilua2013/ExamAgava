using Hero;
using Interations;
using UnityEngine;

namespace Components
{
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField] private PlayerCollisionHandler _playerCollisionHandler;

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
            Destroy(coin.gameObject);
        }
    }
}