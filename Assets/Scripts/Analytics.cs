using UnityEngine;


public class Analytics : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private LevelCompleter _completer;

    private void OnValidate()
    {
        if(_player == null)
            throw new System.Exception($"Не назначен игрок на объекте {gameObject}");
        if(_completer == null)
            throw new System.Exception($"Не назначен объект завершающий уровень на объекте {gameObject}");

    }

    private void OnEnable()
    {
        _player.MoneyChanged += OnChangeMoney;
        _completer.LevelCompleted += OnLevelComplete;
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnChangeMoney;
        _completer.LevelCompleted -= OnLevelComplete;
    }

    private void OnLevelComplete()
    {
        //Send on server
    }

    private void OnChangeMoney(int money)
    {
        //Send on server
    }
}
