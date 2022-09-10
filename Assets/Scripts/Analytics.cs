using UnityEngine;
using UnityEngine.UI;

public class Analytics : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private LevelCompleter _completer;
    [SerializeField] private Button _saveButton;

    private void OnValidate()
    {
        if(_player == null)
            throw new System.Exception($"Не назначен игрок на объекте {gameObject}");
        if(_completer == null)
            throw new System.Exception($"Не назначен объект завершающий уровень на объекте {gameObject}");
        if(_saveButton == null)
            throw new System.Exception($"Не назначена кнопка сохранения денег на объекте {gameObject}");
    }

    private void OnEnable()
    {
        _player.MoneyChanged += OnChangeMoney;
        _completer.LevelCompleted += OnLevelComplete;
        _saveButton.onClick.AddListener(SaveMoney);
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnChangeMoney;
        _completer.LevelCompleted -= OnLevelComplete;
        _saveButton.onClick.RemoveListener(SaveMoney);
    }

    private void OnLevelComplete()
    {
        //Send on server
    }

    private void OnChangeMoney(int money)
    {
        //Send on server
    }

    private void SaveMoney()
    {
        //Send on server
    }
}
