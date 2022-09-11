using System;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerWallet : MonoBehaviour
{
    private int _money;

    public event Action<int> MoneyChanged;

    public int Money => _money;

    private void Start()
    {
        _money = SaveProgress.Money;
    }

    public void AddMoney(int amount)
    {
        SetMoney(_money + amount);
    }

    private void SetMoney(int value)
    {
        _money = value;
        SaveProgress.Money = _money;

        MoneyChanged?.Invoke(_money);
    }
}
