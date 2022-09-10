using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerEffector : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleWalk;

    private AudioSource _source;
    private Rigidbody _rigidbody;

    private void OnValidate()
    {
        if(_particleWalk == null)
            throw new System.Exception($"Не назначен particle на объекте {gameObject}");
    }

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (TryUseEffects() == true)
            PlayEffects();
        else
            StopPlayEffects();
    }

    private bool TryUseEffects()
    {
        return _rigidbody.velocity != Vector3.zero;
    }

    private void PlayEffects()
    {
        _source.Play();
        _particleWalk.Play();
    }

    private void StopPlayEffects()
    {
        _source.Stop();
        _particleWalk.Stop();
    }
}
