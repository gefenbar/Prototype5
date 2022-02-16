using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    public AudioMixer BackGroundaudioMixer;
    public AudioMixer BattleMixer;
    /* public Slider BackGroundaudioSlider;
     public Slider BattleSlider;

     private void start()
     {
         BackGroundaudioSlider.value = BackGroundaudioMixer.SetFloat("volume", volume);
         BattleSlider.value = BattleMixer.SetFloat("battleVolume", volume);
     }*/

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
            BattleMixer.SetFloat("battleVolume", -80);
            BackGroundaudioMixer.SetFloat("volume", -80);

        }
        else
        {
            BattleMixer.SetFloat("battleVolume", -30);
            BackGroundaudioMixer.SetFloat("volume", 0);
        }

    }
}

