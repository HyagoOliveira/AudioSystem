# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [4.3.0] - 2025-12-20
### Added
- Footstep Group Settings

## [4.2.0] - 2025-09-25
### Changed
- Rename AudioData Volume fields to CamelCase

## [4.1.0] - 2025-06-11
### Added
- AudioSourceDictionary.PlaySoundEffect function

## [4.0.0] - 2024-11-27
### Added
- Gamepad Group Settings

### Changed
- Refact AudioData volumes from float into uint (0F -> 1F to 0 -> 100)
- Refact AudioData properties into fields

## [3.1.0] - 2024-07-08
### Added
- AudioLooper
- AudioDisabler

## [3.0.1] - 2023-03-25
### Fixed
- AudibleParticleSystem checks for Unity Particle System directive

## [3.0.0] - 2023-03-16
### Added
- VoiceEffects into DefaultAudioMixer
- AudioSourceExtension class
- SliderAudioGroup component
- TextMeshProAudioGroup component
- AudioGroupSettings ScriptableObject class
- Master, Background, Ambient Effects, Sound Effects and Voice Effects Audio Group Settings assets
- No Effects Snapshot
- AudioSettings Scriptable Object and asset

### Changed
- Remove DisallowMultipleComponent attribute from AudioSourceDictionary
- Remove UI Components from AudioGroup
- If possible, draws AudioGroup.volumeParamName as a Popup field
- Rename AudioManagerData -> AudioData
- Rename AudioManager -> AudioGroupManager

### Removed
- Text Mesh Pro package dependency
- AudioGroupManager component

## [2.0.0] - 2023-01-24
### Changed
- AudioSourceDictionary uses AudioDictionary class.

### Added
- DefaultAudioMixer
- Dependency to TextMeshPro package
- AudioManagerData
- AudioManager
- AudioDictionary class

## [1.1.0] - 2020-02-16
### Added
- Add option to enable other behaviours on AudiableParticleSystem
- Add CHANGELOG
- Add LICENSE

## [1.0.0] - 2020-01-19
### Added
- Release initial version
- Add README
- Add initial files
- Initial commit

[Unreleased]: https://github.com/HyagoOliveira/Audio/compare/4.3.0...main
[4.3.0]: https://github.com/HyagoOliveira/Audio/tree/4.3.0/
[4.2.0]: https://github.com/HyagoOliveira/Audio/tree/4.2.0/
[4.1.0]: https://github.com/HyagoOliveira/Audio/tree/4.1.0/
[4.0.0]: https://github.com/HyagoOliveira/Audio/tree/4.0.0/
[3.1.0]: https://github.com/HyagoOliveira/Audio/tree/3.1.0/
[3.0.1]: https://github.com/HyagoOliveira/Audio/tree/3.0.1/
[3.0.0]: https://github.com/HyagoOliveira/Audio/tree/3.0.0/
[2.0.0]: https://github.com/HyagoOliveira/Audio/tree/2.0.0/
[1.1.0]: https://github.com/HyagoOliveira/Audio/tree/1.1.0/
[1.0.0]: https://github.com/HyagoOliveira/Audio/tree/1.0.0/