using System;
using UnityEngine;

public class LevelCompleter : MonoBehaviour
{
    [SerializeField] private PlayerWallet _playerWallet;

    private Coin[] _coins;

    public event Action LevelCompleted;

    private void OnValidate()
    {
        _playerWallet = FindObjectOfType<PlayerWallet>();
    }

    private void OnEnable()
    {
        _playerWallet.MoneyChanged += OnMoneyChanged;
    }

    private void Start()
    {
        _coins = FindObjectsOfType<Coin>();
    }

    private void OnDisable()
    {
        _playerWallet.MoneyChanged -= OnMoneyChanged;

    }

    private void OnMoneyChanged(int amount)
    {
        int currentTakenCoins = 0;

        foreach(Coin coin in _coins)
            if (coin.IsTaken == true)
                currentTakenCoins++;

        if (currentTakenCoins == _coins.Length)
            LevelCompleted?.Invoke();
    }
}
