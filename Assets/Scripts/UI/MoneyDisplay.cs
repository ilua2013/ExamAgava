using System;
using Hero;
using TMPro;
using UnityEngine;

namespace UI
{
    public class MoneyDisplay : MonoBehaviour
    {
        [SerializeField] private PlayerWallet _playerWallet;
        [SerializeField] private TMP_Text _textMoney;

        private void OnEnable()
        {
            _playerWallet.MoneyChanged += OnMoneyChanged;
        }

        private void OnDisable()
        {
            _playerWallet.MoneyChanged -= OnMoneyChanged;
        }

        private void Start()
        {
            _textMoney.text = _playerWallet.Money.ToString();
        }

        private void OnMoneyChanged(int money)
        {
            _textMoney.text = money.ToString();
        }
    }
}