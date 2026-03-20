#if UNITY_UI
using UnityEngine;
using UnityEngine.UI;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// UI Slider component controlling the <see cref="AudioGroupSettings.Volume"/>.
    /// Your slide should be from 0 -> 100, using integer values.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Slider))]
    public sealed class SliderAudioGroup : AbstractUIAudioGroup
    {
        [SerializeField, Tooltip("The local Slider controlling the Volume.")]
        private Slider slider;

        private void Reset() => slider = GetComponent<Slider>();

        private void OnEnable()
        {
            settings.OnVolumeChanged += HandleVolumeChanged;
            slider.onValueChanged.AddListener(HandleValueChanged);
        }

        private void OnDisable()
        {
            settings.OnVolumeChanged -= HandleVolumeChanged;
            slider.onValueChanged.RemoveListener(HandleValueChanged);
        }

        protected override void SetInitialValue() => SetSliderToVolume();

        private void HandleVolumeChanged() => SetSliderToVolume();
        private void HandleValueChanged(float _) => settings.Volume = GetLinearVolume(slider.normalizedValue);

        private void SetSliderToVolume() => slider.SetValueWithoutNotify(settings.Volume);

        private static uint GetLinearVolume(float normalizedVolume) => (uint)(normalizedVolume * 100);
    }
}
#endif