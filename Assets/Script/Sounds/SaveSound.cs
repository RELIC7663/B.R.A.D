using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class SaveSound 
{
    public static float masterVol, effectsVol;

    public static void SonidoMaste (float a){
        masterVol=a;        
    }

    public static void SonidoEffects(float b){
        
        effectsVol=b;
    }
}
