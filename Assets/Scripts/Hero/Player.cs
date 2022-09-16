using UnityEngine;

namespace Hero
{
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(PlayerWallet))]
    public class Player : MonoBehaviour
    {
        private PlayerWallet _wallet;
        private PlayerHealth _health;

        private void Awake()
        {
            _health = GetComponent<PlayerHealth>();
            _wallet = GetComponent<PlayerWallet>();
        }

        public void AddToWallet(int amount)
        {
            _wallet.AddMoney(amount);
        }

        public void TakeDamage(int damage)
        {
            if (damage <= 0) return;
            
            _health.ApplyDamage(damage);
        }
    }
}