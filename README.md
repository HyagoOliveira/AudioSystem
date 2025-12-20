# Audio

* Audio scripts and presets.
* Unity minimum version: **2018.3**
* Current version: **4.3.0**
* License: **MIT**

## How To Use

### Default Audio Mixer

You may use the [Audio Mixer](/Mixers/DefaultAudioMixer.mixer) provided by this package.

![Default Audio Mixer](/Docs~/DefaultAudioMixer.png "The Default Audio Mixer")

This Mixer contains a *Main*, *Background*, *Sound Effects*, *Ambient Effects*, *Voice Effects* and Gamepad groups; each one with its own exposed *Volume* property.

### Presets

There are common Audio Clip presets inside the [Presets](/Presets) folder. 

Use them on Audio Clip assets depending on how frequently they should play. 

### Serialization

Use the [AudioData](/Runtime/Serialization/AudioData.cs) class with you serialization solution in order to persist audio related data. 

### Other Components

* **SliderAudioGroup**: Makes a local *Slider* component controls a given *AudioMixer* Volume parameter. You have to select a corresponding *AudioGroupSettings*.
* **TextMeshProAudioGroup**: Sets a local *Text Mesh Pro* to display a given *AudioMixer* Volume parameter. You have to select a corresponding *AudioGroupSettings*.
This component is only available if you have installed the **Text Mesh Pro** package.
* **AudibleParticleSystem**: component used to play, stop, pause and resume both **AudioSource** and **ParticleSystem** components attached to the **GameObject**.
* **AudioSourceDictionary**: plays audio clips shots using an **AudioSource** component and an **AudioClip** array.

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-Audio** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/Audio.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.audio":"https://github.com/HyagoOliveira/Audio.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>