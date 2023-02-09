using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioScene : MonoBehaviour
{
     [SerializeField]public  string Scene;
    public void iniciar(){

        //Audio de Muerte por hacer
        //Sounds.instance.PlayAudio(Sounds.instance.dead);
        Time.timeScale = 1;
        CambiarScenne.NivelCarga(Scene);
        //SceneManager.LoadScene(numerodeEcenas);
    }
    

}
    
