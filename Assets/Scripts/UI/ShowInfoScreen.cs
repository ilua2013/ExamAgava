using Hero;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
    public class ShowInfoScreen : Screen
    {
        [SerializeField] private PlayerInfoView _template;
        [SerializeField] private GameObject _container;
        [SerializeField] private Player[] _players;

        private void Start()
        {
            AddPlayersToContainer();
        }

        public event UnityAction ShowInfoButtonClick;

        private void AddPlayersToContainer()
        {
            for (int i = 0; i < _players.Length; i++)
            {
                AddPlayerInfo(_players[i]);
            }
        }

        private void AddPlayerInfo(Player player)
        {
            PlayerInfoView view = Instantiate(_template, _container.transform);
            int money = GetPlayerMoney(player);
            int health = GetPlayerHealth(player);
            view.Initialize(player.name, money, health);
        }

        private int GetPlayerMoney(Player player)
        {
            if (player.TryGetComponent(out PlayerWallet wallet))
                return wallet.Money;

            return 0;
        }

        private int GetPlayerHealth(Player player)
        {
            if (player.TryGetComponent(out PlayerHealth health))
                return health.Value;

            return 0;
        }

        protected override void OnButtonClick()
        {
            ShowInfoButtonClick?.Invoke();
        }

        public override void Open()
        {
            CanvasGroup.alpha = 1f;
            CanvasGroup.blocksRaycasts = true;
            Button.interactable = false;
        }

        public override void Close()
        {
            CanvasGroup.alpha = 0f;
            CanvasGroup.blocksRaycasts = false;
            Button.interactable = true;
        }
    }
}