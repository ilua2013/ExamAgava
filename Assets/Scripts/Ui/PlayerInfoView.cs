using TMPro;
using UnityEngine;

public class PlayerInfoView : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerName;
    [SerializeField] private TMP_Text _playerMoney;
    [SerializeField] private TMP_Text _playerHealth;

    private void OnValidate()
    {
        if(_playerName == null)
            throw new System.Exception($"Не назначен текст отображения имени игрока на объекте {gameObject}");
        if (_playerMoney == null)
            throw new System.Exception($"Не назначен текст отображения денег игрока на объекте {gameObject}");
        if (_playerHealth == null)
            throw new System.Exception($"Не назначен текст отображения здоровья игрока на объекте {gameObject}");
    }

    public void FillTemplate(string name, int money, int health)
    {
        _playerName.text = name;
        _playerMoney.text = money.ToString();
        _playerHealth.text = health.ToString();
    }
}
