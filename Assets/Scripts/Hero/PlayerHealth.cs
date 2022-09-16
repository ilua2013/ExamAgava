using UnityEngine;

namespace Hero
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _health;

        public int Value => _health;

        public void ApplyDamage(int damage)
        {
            _health -= damage;

            if (_health < 1)
                Dead();
        }

        private void Dead()
        {
            print("Помер");
        }
    }
}