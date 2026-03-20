using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Plays the AudioSource clip in loop after played the start sound.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    public sealed class AudioLooper : MonoBehaviour
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        [SerializeField] private AudioSource audio;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        [SerializeField] private AudioClip startSound;

        private void Reset()
        {
            audio = GetComponent<AudioSource>();
            audio.loop = true;
            audio.playOnAwake = false;
        }

        private void OnEnable()
        {
            var time = startSound.length;

            audio.PlayOneShot(startSound);
            Invoke(nameof(PlayLoopSound), time);
        }

        private void OnDisable() => CancelInvoke();

        private void PlayLoopSound() => audio.Play();
    }
}