using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    
    public Text Texto;

    public void Start(){
        string NivelCarga= CambiarScenne.SiguienteNivel;
        StartCoroutine(IniciarCarga(NivelCarga));
    }
    IEnumerator IniciarCarga(string Nivel){
        yield return  new WaitForSeconds(5);
        AsyncOperation Opetarion = SceneManager.LoadSceneAsync(Nivel);
        Opetarion.allowSceneActivation=false;
        while(!Opetarion.isDone)
        {
            
            if(Opetarion.progress>=0.9f){
                Texto.text="Continuar";
                if(Input.anyKey){
                    
                    Opetarion.allowSceneActivation=true;
                }
            }
            yield return null;
        }
        
    }
}
