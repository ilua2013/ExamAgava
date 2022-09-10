using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;

    private void OnValidate()
    {
        if (_joystick == null)
            throw new System.Exception($"Не назначен джойстик на объекте {gameObject}");
        if( _speed <= 0)
            throw new System.Exception($"Не верно назначена скорость на объекте {gameObject}");
    }

    private Rigidbody _rigidbody;
    private const int _zero = 0;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var direction = new Vector3(_joystick.Direction.x, _zero, _joystick.Direction.y) * _speed * Time.deltaTime;
        _rigidbody.velocity = direction;
    }
}
