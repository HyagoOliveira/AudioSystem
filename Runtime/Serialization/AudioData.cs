using System;
using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Data class for Audio.
    /// </summary>
    [Serializable]
    public sealed class AudioData
    {
        [Range(0, maxVolume)] public uint BackgroundVolume;
        [Range(0, maxVolume)] public uint SoundEffectsVolume;
        [Range(0, maxVolume)] public uint AmbientEffectsVolume;
        [Range(0, maxVolume)] public uint VoiceEffectsVolume;
        [Range(0, maxVolume)] public uint FootstepVolume;
        [Range(0, maxVolume)] public uint GamepadVolume;

        private const uint maxVolume = 100;

        /// <summary>
        /// Creates an Audio Data using the given volume for all.
        /// </summary>
        /// <param name="volume">The volume amount.</param>
        public AudioData(uint volume = maxVolume) :
            this(volume, volume, volume, volume, volume, volume)
        { }

        /// <summary>
        /// Creates an Audio Data using the given volumes.
        /// </summary>
        /// <param name="backgroundVolume">The background volume amount.</param>
        /// <param name="soundEffectsVolume">The sound effects volume amount.</param>
        /// <param name="ambientEffectsVolume">The ambient effects volume amount.</param>
        /// <param name="voiceEffectsVolume">The voice effects volume amount.</param>
        /// <param name="footstepVolume">The Footstep volume amount.</param>
        /// <param name="gamepadVolume">The Gamepad volume amount.</param>
        public AudioData(
            uint backgroundVolume,
            uint soundEffectsVolume,
            uint ambientEffectsVolume,
            uint voiceEffectsVolume,
            uint footstepVolume,
            uint gamepadVolume
        )
        {
            BackgroundVolume = backgroundVolume;
            SoundEffectsVolume = soundEffectsVolume;
            AmbientEffectsVolume = ambientEffectsVolume;
            VoiceEffectsVolume = voiceEffectsVolume;
            FootstepVolume = footstepVolume;
            GamepadVolume = gamepadVolume;
        }
    }
}