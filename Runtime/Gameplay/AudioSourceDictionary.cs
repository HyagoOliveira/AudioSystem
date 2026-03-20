using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Plays audio clips shots using an <see cref="AudioSource"/> component and an <see cref="AudioDictionary"/>.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public sealed class AudioSourceDictionary : MonoBehaviour
    {
        [SerializeField, Tooltip("The local AudioSource component used to play audio shots.")]
        private AudioSource source;
        [field: SerializeField, Tooltip("The Audio Clip Dictionary.")]
        public AudioDictionary Dictionary { get; private set; }

        private void Reset() => source = GetComponent<AudioSource>();
        private void Awake() => Dictionary.Initialize();

        /// <summary>
        /// Plays an audio clip using the given index.
        /// </summary>
        /// <param name="index"><inheritdoc cref="AudioDictionary.GetClip(int)"/></param>
        public void Play(int index) => source.PlayOneShot(Dictionary.GetClip(index));

        /// <summary>
        /// Plays an audio clip using the given name.
        /// </summary>
        /// <param name="name"><inheritdoc cref="AudioDictionary.GetClip(string)"/></param>
        public void Play(string name) => source.PlayOneShot(Dictionary.GetClip(name));

        /// <summary>
        /// Plays a random audio clip.
        /// </summary>
        public void PlayRandom() => source.PlayOneShot(Dictionary.GetRandomClip());

        /// <summary>
        /// <inheritdoc cref="Play(string)"/>
        /// <para>Use this function inside Audio Clips.</para>
        /// </summary>
        /// <param name="name"><inheritdoc cref="AudioDictionary.GetClip(string)"/></param>
        public void PlaySoundEffect(string name) => Play(name);

        /// <summary>
        /// Pauses the Audio Source.
        /// </summary>
        public void Pause() => source.Pause();

        /// <summary>
        /// Plays the Audio Source if it is not playing.
        /// </summary>
        public void Resume()
        {
            if (!source.isPlaying) source.Play();
        }
    }
}