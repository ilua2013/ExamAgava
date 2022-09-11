using UnityEngine;

public class UIPlayersInfo : MonoBehaviour
{
    [SerializeField] private PlayerInfoView _template;
    [SerializeField] private GameObject _container;

    private Player[] _players;

    private void OnValidate()
    {
        if(_template == null)
            throw new System.Exception($"Не установлен шаблон отображения на объекте {gameObject}");
        if(_container == null)
            throw new System.Exception($"Не назначен контейнер для отображения на объекте {gameObject}");
    }

    private void Start()
    {
        _players = GameObject.FindObjectsOfType<Player>(); //Все же я думаю здесь должен быть запрос игроков с сервера
        AddPlayersInfo();
    }

    private void AddPlayersInfo()
    {
        for(int i = 0; i < _players.Length; i++)
        {
            AddInfo(_players[i]);
        }
    }

    private void AddInfo(Player player)
    {
        PlayerInfoView view = Instantiate(_template, _container.transform);

        int money = GetPlayerMoney(player);
        int health = GetPlayerHealth(player);

        view.FillTemplate(player.Name, money, health);
    }

    private int GetPlayerMoney(Player player)
    {
        if (player.TryGetComponent<PlayerWallet>(out PlayerWallet wallet))
            return wallet.Money;
        else
            return 0;
    }

    private int GetPlayerHealth(Player player)
    {
        if (player.TryGetComponent<PlayerHealth>(out PlayerHealth health))
            return health.Value;
        else
            return 0;
    }
}
