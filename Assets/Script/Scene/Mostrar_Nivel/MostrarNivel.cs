using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MostrarNivel : MonoBehaviour
{
    [SerializeField] public GameObject continuar;
    [SerializeField] public GameObject Seleccionarnivel;
    [SerializeField] public GameObject Nivel1;
    [SerializeField] public GameObject Nivel2;
    [SerializeField] public GameObject Nivel3;
    [SerializeField] public GameObject Nivel4;
    //[SerializeField] public GameObject[] Niveles;
    [SerializeField] public GameObject Regresar;

    [SerializeField] public GameObject Opciones;

    [SerializeField] public GameObject CONF;


    public void SeleccionarNivel()
    {

        int a = PathId.PathIdget();
        //Debug.Log(SaveSystem.LoadData(a).Nivelne());
        if (SaveSystem.LoadData(a).Nivelne() == 1)
        {
            Nivel1.SetActive(true);
            Nivel2.SetActive(false);
            Nivel3.SetActive(false);
            Nivel4.SetActive(false);

        }
        else if (SaveSystem.LoadData(a).Nivelne() == 2)
        {
            Nivel1.SetActive(true);
            Nivel2.SetActive(true);
            Nivel3.SetActive(false);
            Nivel4.SetActive(false);
        }if (SaveSystem.LoadData(a).Nivelne() == 3)
        {
            Nivel1.SetActive(true);
            Nivel2.SetActive(true);
            Nivel3.SetActive(true);
            Nivel4.SetActive(false);
        }
        else if (SaveSystem.LoadData(a).Nivelne() == 4)
        {
            Nivel1.SetActive(true);
            Nivel2.SetActive(true);
            Nivel3.SetActive(true);
            Nivel4.SetActive(true);
        }

        //foreach(GameObject nivel in Niveles)
        //{
            //nivel.SetActive(true);
        //}
        
        continuar.SetActive(false);
        Seleccionarnivel.SetActive(false);
        Opciones.SetActive(false);

        Regresar.SetActive(true);
    }
    public void RegresarMenu()
    {
        continuar.SetActive(true);
        Seleccionarnivel.SetActive(true);
        Opciones.SetActive(true);
        Nivel1.SetActive(false);
        Nivel2.SetActive(false);
        Nivel3.SetActive(false);
        Nivel4.SetActive(false);
        Regresar.SetActive(false);

        CONF.SetActive(false);

    }

    public void MostrarOpciones()
    {
        continuar.SetActive(false);
        Seleccionarnivel.SetActive(false);
        Opciones.SetActive(false);


        CONF.SetActive(true);

        Regresar.SetActive(true);
    }


}
