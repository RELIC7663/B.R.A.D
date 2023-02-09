using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Sounds : MonoBehaviour
{

    [SerializeField] public AudioMixer MusicMixer, effectsMixer;
    [SerializeField] public AudioSource BGmusic, dead;
    public static Sounds instance;
    [SerializeField][Range(-80, 0f)] public float masterVol, effectsVol;

    [SerializeField] Slider masterSlider, effectsSlder;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    void Start()
    {
        masterVol=SaveSound.masterVol;
        effectsVol=SaveSound.effectsVol;
        PlayAudio(BGmusic);
        

        masterSlider.minValue=-50;
        masterSlider.maxValue=-5;

        effectsSlder.minValue=-50;
        effectsSlder.maxValue=-5;
        
        masterSlider.value= masterVol;
        effectsSlder.value=effectsVol;

    }

    void Update()
    {
        EffectsVolume();
        MasterVolume();
    }

    public void MasterVolume()
    {
        SaveSound.SonidoMaste(masterSlider.value);
        MusicMixer.SetFloat("MasterMusic", masterSlider.value);
    }
    public void EffectsVolume()
    {
        SaveSound.SonidoEffects(effectsSlder.value);
        effectsMixer.SetFloat("MasterEffecst", effectsSlder.value);
        
    }


    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
}
