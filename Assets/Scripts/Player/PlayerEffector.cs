using UnityEngine;

public class PlayerEffector : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleWalk;
    [SerializeField] private PlayerMover _playerMover;

    private void OnValidate()
    {
        if(_particleWalk == null)
            throw new System.Exception($"Не назначен particle на объекте {gameObject}");

        _playerMover = FindObjectOfType<PlayerMover>();
    }

    private void OnEnable()
    {
        _playerMover.MoveStarted += OnMoveStarted;
        _playerMover.MoveFinished += OnMoveFinished;
    }

    private void OnDisable()
    {
        _playerMover.MoveStarted -= OnMoveStarted;
        _playerMover.MoveFinished -= OnMoveFinished;
    }

    private void OnMoveStarted()
    {
        _particleWalk.Play();
    }

    private void OnMoveFinished()
    {
        _particleWalk.Stop();
    }
}
