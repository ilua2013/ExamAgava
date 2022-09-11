using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField, Min(1)] private float _speed;

    private Rigidbody _rigidbody;
    private bool isMove;
    private bool _isMoveLastState;

    public event Action MoveStarted;
    public event Action MoveFinished;

    private void OnValidate()
    {
        _joystick = FindObjectOfType<Joystick>();
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        SetState();
        TryChangeLastState();
    }

    private void Move()
    {
        var direction = new Vector3(_joystick.Direction.x, 0, _joystick.Direction.y) * _speed * Time.deltaTime;
        _rigidbody.velocity = direction;
    }

    private void SetState()
    {
        isMove = _rigidbody.velocity != Vector3.zero;
    }

    private void TryChangeLastState()
    {
        if (_isMoveLastState != isMove)
        {
            _isMoveLastState = isMove;
            CallEvent();
        }
    }

    private void CallEvent()
    {
        if (isMove == true)
            MoveStarted?.Invoke();
        else
            MoveFinished?.Invoke();
    }


}
