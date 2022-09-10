using System;
using UnityEngine;

public class LevelCompleter : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Coin[] _coins;
    private int _currentCollectedCoins;

    public event Action LevelCompleted;

    private void OnValidate()
    {
        if (_player == null)
            throw new System.Exception($"Не назначен игрок на объекте {gameObject}");
    }

    private void OnEnable()
    {
        _player.MoneyChanged += OnMoneyChanged;
    }

    private void Start()
    {
        _coins = FindObjectsOfType<Coin>();
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnMoneyChanged;

    }

    private void OnMoneyChanged(int amount)
    {
        _currentCollectedCoins++;
        TryCompleteLevel();
    }

    private void TryCompleteLevel()
    {
        if(_currentCollectedCoins == _coins.Length)
            LevelCompleted?.Invoke();
    }
}
