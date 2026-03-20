#if UNITY_PARTICLE_SYSTEM
using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Component used to play, stop, pause and resume both AudioSource and ParticleSystem components attached to this GameObject.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(ParticleSystem))]
    public class AudibleParticleSystem : MonoBehaviour
    {
        [SerializeField, Tooltip("The AudioSource component used to play.")]
        protected AudioSource audioSource;
        [SerializeField, Tooltip("The ParticleSystem component used to play.")]
        protected ParticleSystem partSystem;
        [SerializeField, Tooltip("Other behaviours to enable when play.")]
        protected Behaviour[] otherBehaviours;

        private void Reset()
        {
            audioSource = GetComponent<AudioSource>();
            partSystem = GetComponent<ParticleSystem>();

            audioSource.playOnAwake = partSystem.main.playOnAwake;
            audioSource.loop = partSystem.main.loop;
        }

        /// <summary>
        /// Plays both Audio Source and Particle System.
        /// </summary>
        public void Play()
        {
            audioSource.Play();
            partSystem.Play();
            EnableBehaviours(true);
        }

        /// <summary>
        /// Stops both Audio Source and Particle System.
        /// </summary>
        public void Stop()
        {
            audioSource.Stop();
            partSystem.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            EnableBehaviours(false);
        }

        /// <summary>
        /// Enables <see cref="otherBehaviours"/>.
        /// </summary>
        /// <param name="enabled">True to enable, false otherwise.</param>
        public void EnableBehaviours(bool enabled)
        {
            foreach (Behaviour component in otherBehaviours)
            {
                component.enabled = enabled;
            }
        }

        /// <summary>
        /// Pauses both Audio Source and Particle System.
        /// </summary>
        public void Pause()
        {
            audioSource.Pause();
            partSystem.Pause();
        }

        /// <summary>
        /// Plays both Audio Source and Particle System if they are not playing.
        /// </summary>
        public void Resume()
        {
            if (!audioSource.isPlaying) audioSource.Play();
            if (!partSystem.isPlaying)
            {
                partSystem.Play();
                EnableBehaviours(true);
            }
        }
    }
}
#endif