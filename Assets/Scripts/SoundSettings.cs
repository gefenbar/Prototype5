using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class SoundSettings : MonoBehaviour
{
    public AudioMixer BackGroundaudioMixer;
    public AudioMixer BattleMixer;
    public Slider BackGroundaudioSlider;
    public Slider BattleSlider;
    

    public void Awake()
    {
        float BackGroundaudioVolume;
        float BattleVolume;
        bool result = BackGroundaudioMixer.GetFloat("volume", out BackGroundaudioVolume);
        bool result2 = BattleMixer.GetFloat("battleVolume", out BattleVolume);
        BackGroundaudioSlider.value = BackGroundaudioVolume;
        BattleSlider.value = BattleVolume;

    }

    public void SetBackgroundVolume(float volume)
    {
        BackGroundaudioMixer.SetFloat("volume", volume);
    }
    public void SetBattleVolume(float volume)
    {
        BattleMixer.SetFloat("battleVolume", volume);
    }

    public void SetMute(bool isMute)
    {
        if (isMute == true)
        {
            BackGroundaudioSlider.value = -80;
            BattleSlider.value = -80;
            BattleMixer.SetFloat("battleVolume", -80);
            BackGroundaudioMixer.SetFloat("volume", -80);

        }
        else
        {
            BackGroundaudioSlider.value = -30;
            BattleSlider.value = -30;
            BattleMixer.SetFloat("battleVolume", -30);
            BackGroundaudioMixer.SetFloat("volume", -30);
        }

    }
}

