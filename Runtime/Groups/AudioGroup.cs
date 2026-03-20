using System;
using UnityEngine;
using UnityEngine.Audio;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Component for Audio Groups.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class AudioGroup : MonoBehaviour
    {
        [SerializeField, Tooltip("Your game AudioMixer asset.")]
        private AudioMixer mixer;
        [Tooltip("The Volume Exposed Parameter name inside the AudioMixer asset.")]
        public string volumeParamName;

        public event Action<float> OnVolumeChanged;
        public event Action<bool> OnInteractableChanged;

        /// <summary>
        /// Your game AudioMixer asset.
        /// </summary>
        public AudioMixer Mixer => mixer;

        /// <summary>
        /// The Volume in linear range (0F -> 1F).
        /// </summary>
        public float Volume
        {
            get
            {
                var hasVolume = mixer.GetFloat(volumeParamName, out float volume);
                return hasVolume ? DecibelToLinear(volume) : 0F;
            }
            set
            {
                mixer.SetFloat(volumeParamName, LinearToDecibel(value));
                OnVolumeChanged?.Invoke(value);
            }
        }

        /// <summary>
        /// Whether this Audio Group is interactable.
        /// </summary>
        public bool Interactable
        {
            get => enabled;
            set
            {
                enabled = value;
                Volume = enabled ? 1F : 0F;
                OnInteractableChanged?.Invoke(enabled);
            }
        }

        private const float maxVolumeDB = 20F;
        private const float minVolumeDB = -80F;

        private static float DecibelToLinear(float value) => Mathf.Pow(10F, value / maxVolumeDB);

        private static float LinearToDecibel(float value)
        {
            var hasValue = value > 0F;
            return hasValue ?
                Mathf.Log10(value) * maxVolumeDB :
                minVolumeDB;
        }
    }
}