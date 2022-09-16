using Effects;
using UnityEngine;

namespace Hero
{
    [RequireComponent(typeof(SoundEffects))]
    [RequireComponent(typeof(ParticleEffects))]
    public class PlayerEffects : MonoBehaviour
    {
        [SerializeField] private PlayerMover _playerMover;

        private ParticleEffects _particlesEffects;
        private SoundEffects _soundEffects;

        private void Awake()
        {
            _soundEffects = GetComponent<SoundEffects>();
            _particlesEffects = GetComponent<ParticleEffects>();
        }

        private void Update()
        {
            if (_playerMover.IsMoving && _soundEffects.IsPlaying == false)
            {
                _particlesEffects.Play();
                _soundEffects.Play();
            }
            else if (_playerMover.IsMoving == false)
            {
                _particlesEffects.Stop();
                _soundEffects.Stop();
            }
        }
    }
}