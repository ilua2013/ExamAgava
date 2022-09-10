using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _money;
    [SerializeField] private string _name;

    private const int _zero = 0;

    public event Action<int> MoneyChanged;

    public string Name => _name;
    public int Money => _money;
    public int Health => _health;

    private void OnValidate()
    {
        if(_health <= 0)
            throw new System.Exception($"Неверно назначено здоровье на объекте {gameObject}");
        if(_name == null)
            throw new System.Exception($"Не присвоено имя игрока {gameObject}");
    }

    private void Start()
    {
        _money = _zero;
        MoneyChanged?.Invoke(_money);
    }

    public void AddMoney(int ammout)
    {
        _money += ammout;
        MoneyChanged?.Invoke(_money);
    }

    private void ApplyDamage(int damage)
    {
        _health -= damage;
        TryDie();
    }

    private void TryDie()
    {
        if (_health < 1)
            Dead();
    }

    private void Dead()
    {
        //Do somthing
    }
}
