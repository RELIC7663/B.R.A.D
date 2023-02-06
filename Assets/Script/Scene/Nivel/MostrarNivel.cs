using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarNivel : MonoBehaviour
{
    [SerializeField]public GameObject continuar;
    [SerializeField]public GameObject Seleccionarnivel;
    [SerializeField]public GameObject Nivel1;
    [SerializeField]public GameObject Nivel2;
    [SerializeField]public GameObject Regresar;

    [SerializeField]public GameObject Opciones;
    
    [SerializeField]public GameObject CONF;
    

    public void SeleccionarNivel() {
        continuar.SetActive(false);
        Seleccionarnivel.SetActive(false);
        Opciones.SetActive(false);
        Nivel1.SetActive(true);
        Nivel2.SetActive(true);
        Regresar.SetActive(true);
    }
    public void RegresarMenu() {
        continuar.SetActive(true);
        Seleccionarnivel.SetActive(true);
        Opciones.SetActive(true);
        Nivel1.SetActive(false);
        Nivel2.SetActive(false);
        Regresar.SetActive(false);

        CONF.SetActive(false);
        
    }

    public void MostrarOpciones() {
        continuar.SetActive(false);
        Seleccionarnivel.SetActive(false);
        Opciones.SetActive(false);
        
        
        CONF.SetActive(true);

        Regresar.SetActive(true);
    }


}
