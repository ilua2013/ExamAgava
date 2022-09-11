using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField, Min(1)] private int _ammount;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent<PlayerWallet>(out PlayerWallet wallet))
        {
            wallet.AddMoney(_ammount);
            Destroy(gameObject);
        }    
    }
}
