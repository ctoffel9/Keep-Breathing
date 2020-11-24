using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVol : MonoBehaviour
{
    public AudioMixer Music;
    public AudioMixer SFX;

    public void SetLevelM (float slidervalue)
    {
        Music.SetFloat("MusicVol", Mathf.Log10(slidervalue * 20));
    }

    public void SetLevelS(float slidervalue)
    {
        SFX.SetFloat("SFXVol", Mathf.Log10(slidervalue * 20));
    }
}
