using UnityEngine;

namespace Hero
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField,Min(0)] private int _health;

        public int Health => _health;

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