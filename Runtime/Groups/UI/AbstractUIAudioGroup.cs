using UnityEngine;

namespace ActionCode.AudioSystem
{
    /// <summary>
    /// Abstract UI component for <see cref="AudioGroupSettings"/>.
    /// </summary>
    public abstract class AbstractUIAudioGroup : MonoBehaviour
    {
        [SerializeField, Tooltip("The Audio Group Settings.")]
        protected AudioGroupSettings settings;

        protected virtual void Start() => SetInitialValue();

        protected abstract void SetInitialValue();
    }
}