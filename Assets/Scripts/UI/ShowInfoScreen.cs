using Hero;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ShowInfoScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private Button _button;
        [SerializeField] private PlayerInfoView _template;
        [SerializeField] private GameObject _container;
        [SerializeField] private PlayerInfo[] _playerInfos;

        private void OnValidate()
        {
            _playerInfos = FindObjectsOfType<PlayerInfo>();
        }

        private void Start()
        {
            Close();
            AddPlayersToContainer();
        }

        private void AddPlayersToContainer()
        {
            foreach (var playerInfo in _playerInfos)
            {
                AddPlayerInfo(playerInfo);
            }
        }

        private void AddPlayerInfo(PlayerInfo playerInfo)
        {
            PlayerInfoView view = Instantiate(_template, _container.transform);
            view.Initialize(playerInfo.name, playerInfo.Money, playerInfo.Health);
        }

        private void Open()
        {
            _canvasGroup.alpha = 1f;
            _canvasGroup.blocksRaycasts = true;
            _button.interactable = false;
        }

        private void Close()
        {
            _canvasGroup.alpha = 0f;
            _canvasGroup.blocksRaycasts = false;
            _button.interactable = true;
        }
    }
}