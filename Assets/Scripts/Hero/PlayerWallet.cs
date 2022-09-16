using System;
using Interactions;
using UnityEngine;

namespace Hero
{
    public class PlayerWallet : MonoBehaviour
    {
        private int _money;

        public int Money => _money;

        public event Action<int> MoneyChanged;

        private void Awake()
        {
            GetMoneyFromSave();
        }

        public void AddMoney(int money)
        {
            SetMoney(_money + money);
            MoneyChanged?.Invoke(_money);
        }

        private void GetMoneyFromSave()
        {
            _money = SaveProgress.Money;
        }

        private void SetMoney(int value)
        {
            _money = value;
            SaveProgress.Money = _money;
        }
    }
}