using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;

    private void ApplyDamage(int damage)
    {
        if (damage > 0)
        {
            _health -= damage;
            TryDie();
        }        
    }

    private void TryDie()
    {
        if (_health < 1)
            Dead();
    }

    private void Dead()
    {
        //Do somthing
    }
}
