using Hero;
using Level;
using UnityEngine;

namespace Analytics
{
    public class PlayerEventsAnalytics : MonoBehaviour
    {
        [SerializeField] private LevelHolder _levelHolder;
        [SerializeField] private PlayerWallet _playerWallet;

        private void OnEnable()
        {
            _levelHolder.LevelCompleted += OnLevelCompleted;
            _playerWallet.MoneyChanged += OnChangeMoney;
        }

        private void OnDisable()
        {
            _levelHolder.LevelCompleted -= OnLevelCompleted;
            _playerWallet.MoneyChanged -= OnChangeMoney;
        }

        public void OnLevelCompleted()
        {
            print("Всё выдержали нахуй, ахуенно, вот это парилка нахуй, эхх, за этой парилкой и надо жить");
        }

        public void OnChangeMoney(int money)
        {
            print("Рубль будет хэ-хэ");
        }
    }
}