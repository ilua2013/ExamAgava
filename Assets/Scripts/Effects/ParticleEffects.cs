using UnityEngine;

namespace Effects
{
    public class ParticleEffects : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _walk;

        public void Play()
        {
            _walk.Play();
        }

        public void Stop()
        {
            _walk.Stop();
        }
    }
}