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
        PlayAudio(BGmusic);
        

        masterSlider.minValue=-80;
        masterSlider.maxValue=0;

        effectsSlder.minValue=-80;
        effectsSlder.maxValue=0;
        
        masterSlider.value= masterVol;
        effectsSlder.value=effectsVol;

    }

    // Update is called once per frame
    void Update()
    {
        EffectsVolume();
        MasterVolume();
    }

    public void MasterVolume()
    {
        MusicMixer.SetFloat("MasterMusic", masterSlider.value);
    }
    public void EffectsVolume()
    {
        effectsMixer.SetFloat("MasterEffecst", effectsSlder.value);
    }



    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
}
