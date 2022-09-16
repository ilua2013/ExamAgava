using System;
using UnityEngine;

namespace Hero
{
    public class PlayerWallet : MonoBehaviour
    {
        private readonly string _moneyKey = "Money";
        public int Money { get; private set; }

        public event Action<int> MoneyChanged;

        private void Awake()
        {
            GetMoney();
        }

        public void AddMoney(int money)
        {
            Money += money;
            SetMoney();
            MoneyChanged?.Invoke(Money);
        }

        private void GetMoney()
        {
            Money = PlayerPrefs.GetInt(_moneyKey);
            MoneyChanged?.Invoke(Money);
        }

        private void SetMoney()
        {
            PlayerPrefs.SetInt(_moneyKey, Money);
        }
    }
}