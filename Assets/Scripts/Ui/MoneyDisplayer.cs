using TMPro;
using UnityEngine;

public class MoneyDisplayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _money;
    [SerializeField] private Player _player;

    private void OnValidate()
    {
        if(_money == null)
            throw new System.Exception($"Не назначен текст на объекте {gameObject}");
        if(_player == null)
            throw new System.Exception($"Не назначен игрок на объекте {gameObject}");
    }

    private void OnEnable()
    {
        _player.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    }
}
