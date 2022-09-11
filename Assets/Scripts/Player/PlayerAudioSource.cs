using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerAudioSource : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;

    private AudioSource _source;

    private void OnValidate()
    {
        _playerMover = FindObjectOfType<PlayerMover>();
    }

    private void Start()
    {
        _source = GetComponent<AudioSource>();
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
        _source.Play();
    }

    private void OnMoveFinished()
    {
        _source.Stop();
    }
}
