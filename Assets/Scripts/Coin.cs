using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _ammount;

    private void OnValidate()
    {
        if(_ammount <= 0)
            throw new System.Exception($"Неверно назначено значение на объекте {gameObject}");
    }

    public int Ammount => _ammount;
}
