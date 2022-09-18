using UnityEngine;

namespace Effects
{
    public class SoundEffects : MonoBehaviour
    {
        [SerializeField] private AudioSource _source;

        public bool IsPlaying => _source.isPlaying;

        public void Play()
        {
            if (IsPlaying == false)
            {
                _source.Play();
            }
        }

        public void Stop()
        {
            if (IsPlaying)
            {
                _source.Stop();
            }
        }
    }
}