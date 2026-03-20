using System;
using UnityEngine;
using UnityEngine.Audio;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Scriptable Settings for an Audio Group.
    /// </summary>
    [CreateAssetMenu(fileName = "AudioGroupSettings", menuName = "ActionCode/Audio/Group Settings", order = 110)]
    public sealed class AudioGroupSettings : ScriptableObject
    {
        [SerializeField, Tooltip("The AudioMixer asset used on your game.")]
        private AudioMixer mixer;
        [Tooltip("The Volume Exposed Parameter name inside the above AudioMixer.")]
        public string volumeParamName;

        /// <summary>
        /// Event fired every time the volume changes. 
        /// <para>Use <see cref="Volume"/> to check the current volume.</para>
        /// </summary>
        public event Action OnVolumeChanged;

        /// <summary>
        /// Your game AudioMixer asset.
        /// </summary>
        public AudioMixer Mixer => mixer;

        /// <summary>
        /// The Volume in linear range (0 -> 100).
        /// </summary>
        public uint Volume
        {
            get
            {
                var hasVolumeParam = mixer.GetFloat(volumeParamName, out float volume);
                return hasVolumeParam ? DecibelToLinear(volume) : 0;
            }
            set
            {
                mixer.SetFloat(volumeParamName, LinearToDecibel(value));
                OnVolumeChanged?.Invoke();
            }
        }

        private const uint noVolume = 0;
        private const uint defaultVolume = 100;
        private const float maxVolumeDB = 20F;
        private const float minVolumeDB = -80F;

        /// <summary>
        /// Checks if the Audio Group has Volume.
        /// </summary>
        /// <returns>Whether the Audio Group has Volume.</returns>
        public bool HasVolume() => Volume == noVolume;

        /// <summary>
        /// Resets the <see cref="Volume"/> to its default value.
        /// </summary>
        public void ResetVolume() => Volume = defaultVolume;

        private static uint DecibelToLinear(float value)
        {
            var volumeDB = Mathf.Pow(10F, value / maxVolumeDB);
            return (uint)(volumeDB * 100);
        }

        private static float LinearToDecibel(uint value)
        {
            var hasValue = value > noVolume;
            var valuDB = value * 0.01F;
            var a = hasValue ?
                Mathf.Log10(valuDB) * maxVolumeDB :
                minVolumeDB;

            return a;
        }
    }
}