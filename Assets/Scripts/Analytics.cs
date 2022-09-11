using UnityEngine;

public class Analytics : MonoBehaviour
{
    [SerializeField] private PlayerWallet _playerWallet;
    [SerializeField] private LevelCompleter _completer;

    private void OnValidate()
    {
        _playerWallet = FindObjectOfType<PlayerWallet>();
        _completer = FindObjectOfType<LevelCompleter>();

    }

    private void OnEnable()
    {
        _playerWallet.MoneyChanged_getMoney += OnChangeMoney;
        _completer.LevelCompleted += OnLevelComplete;
    }

    private void OnDisable()
    {
        _playerWallet.MoneyChanged_getMoney -= OnChangeMoney;
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
