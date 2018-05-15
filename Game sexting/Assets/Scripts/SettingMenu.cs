using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour {

    public AudioMixer musicVolume;
    public AudioMixer soundEffectsVolume;

    public void SetVolume(float volume)
    {
        musicVolume.SetFloat("Volume", volume);
    }
    public void SetSoundEffects(float volume)
    {
        soundEffectsVolume.SetFloat("Volume", volume);
    }
}
