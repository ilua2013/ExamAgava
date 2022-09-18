using UnityEngine;

namespace Hero
{
    public class PlayerInfo : MonoBehaviour
    {
        [SerializeField] private PlayerWallet _wallet;
        [SerializeField] private PlayerHealth _health;

        public int Money => _wallet.Money;
        public int Health => _health.Health;

        private void OnValidate()
        {
            _wallet = GetComponentInChildren<PlayerWallet>();
            _health = GetComponentInChildren<PlayerHealth>();
        }
    }
}