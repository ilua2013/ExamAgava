using System;
using Hero;
using UnityEngine;

namespace Interactions
{
    public class Coin : MonoBehaviour
    {
        [SerializeField, Min(1)] private int _reward;

        public event Action<Coin> Taked;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerWallet playerWallet))
            {
                playerWallet.AddMoney(_reward);
                Taked?.Invoke(this);
                Destroy();
            }
        }

        private void Destroy()
        {
            Destroy(this);
        }
    }
}