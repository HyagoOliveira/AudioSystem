using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Extension class for <see cref="AudioSource"/>.
    /// </summary>
    public static class AudioSourceExtension
    {
        /// <summary>
        /// Sets the Audio source to play as a 2D sound.
        /// </summary>
        /// <param name="source"></param>
        public static void SetSpatialBlendTo2D(this AudioSource source) => source.spatialBlend = 0F;

        /// <summary>
        /// Sets the Audio source to play as a 3D sound.
        /// </summary>
        /// <param name="source"></param>
        public static void SetSpatialBlendTo3D(this AudioSource source) => source.spatialBlend = 1F;
    }
}