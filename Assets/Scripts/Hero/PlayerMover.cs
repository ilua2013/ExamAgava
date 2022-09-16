using UnityEngine;

namespace Hero
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private PlayerInput _playerInput;
        private Rigidbody _rigidbody;

        public bool IsMoving => _playerInput.Axis.magnitude > Constants.Epsilon;

        private void Awake()
        {
            _playerInput = GetComponent<PlayerInput>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (IsMoving)
            {
                _rigidbody.velocity = _playerInput.Axis * _speed;
            }
        }
    }
}