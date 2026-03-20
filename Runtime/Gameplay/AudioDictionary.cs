using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ActionCode.AudioSystem
{
	/// <summary>
	/// Audio Dictionary data.
	/// <para>Play AudioClips using theirs names or a random one.</para>
	/// </summary>
	[Serializable]
    public sealed class AudioDictionary
    {
	    [SerializeField, Tooltip("The Audio Clips. You can play them using theirs names.")]
	    private AudioClip[] clips;
	    
	    private Dictionary<string, AudioClip> audioDictionary;
	    
	    /// <summary>
	    /// Initializes the audio dictionary.
	    /// </summary>
	    public void Initialize()
	    {
		    audioDictionary = new Dictionary<string, AudioClip>(clips.Length);
		    foreach (AudioClip clip in clips)
		    {
			    audioDictionary.Add(clip.name, clip);
		    }
	    }
	    
	    /// <summary>
	    /// Gets a random audio clip.
	    /// </summary>
	    /// <returns>A random <see cref="AudioClip"/> instance.</returns>
	    public AudioClip GetRandomClip()
	    {
		    int randomIndex = Random.Range(0, clips.Length);
		    return GetClip(randomIndex);
	    }
	    
	    /// <summary>
	    /// Gets an audio clip using the given index.
	    /// </summary>
	    /// <param name="index">The index of the audio clip. No checking is done.</param>
	    /// <returns>An <see cref="AudioClip"/> instance or <see cref="IndexOutOfRangeException"/>.</returns>
	    public AudioClip GetClip(int index) => clips[index];
	    
	    /// <summary>
	    /// Gets an audio clip using the given name.
	    /// </summary>
	    /// <param name="name">The name of the audio clip. No checking is done.</param>
	    /// <returns>An <see cref="AudioClip"/> instance or <see cref="KeyNotFoundException"/>.</returns>
	    public AudioClip GetClip(string name) => audioDictionary[name];
	    
	    /// <summary>
	    /// Tries to get an audio clip using the given name.
	    /// </summary>
	    /// <param name="name">The name of audio clip.</param>
	    /// <param name="clip">The Audio Clip instance found.</param>
	    /// <returns>Whether the given clip was found.</returns>
	    public bool TryGetClip(string name, out AudioClip clip) => 
		    audioDictionary.TryGetValue(name, out clip);
    }
}