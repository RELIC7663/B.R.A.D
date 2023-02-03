using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioScene : MonoBehaviour
{
     [SerializeField]public int numerodeEcenas;
    public void iniciar(){

        Sounds.instance.PlayAudio(Sounds.instance.dead);
        
        SceneManager.LoadScene(numerodeEcenas);
    }
}
    
