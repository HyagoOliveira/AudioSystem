using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Disables this GameObject after the audio clip ends.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(AudioSource))]
    public sealed class AudioDisabler : MonoBehaviour
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        [SerializeField] private AudioSource audio;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        private void Reset() => audio = GetComponent<AudioSource>();
        private void OnEnable() => Invoke(nameof(Disable), audio.clip.length);
        private void OnDisable() => CancelInvoke();

        private void Disable() => gameObject.SetActive(false);
    }
}