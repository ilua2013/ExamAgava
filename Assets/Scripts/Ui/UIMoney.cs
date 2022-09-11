using TMPro;
using UnityEngine;

public class UIMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;
    [SerializeField] private PlayerWallet _playerWallet;

    private void OnValidate()
    {
        if(_textMoney == null)
            throw new System.Exception($"Не назначен текст на объекте {gameObject}");
        
        _playerWallet = FindObjectOfType<PlayerWallet>();
    }

    private void OnEnable()
    {
        _playerWallet.MoneyChanged_getMoney += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _playerWallet.MoneyChanged_getMoney -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _textMoney.text = money.ToString();
    }
}
