using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CambiarScenne 
{
    public static string SiguienteNivel;
    public static void NivelCarga(string Nombre){
        SiguienteNivel = Nombre;
        SceneManager.LoadScene("PantalladeCarga");
    }
}

