using Hero;
using UnityEngine;

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