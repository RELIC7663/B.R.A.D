using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarSlots : MonoBehaviour
{
    
    [SerializeField]public GameObject continuar;
    [SerializeField]public GameObject NewGame;
    [SerializeField]public GameObject Slot1;
    [SerializeField]public GameObject Slot3;
    [SerializeField]public GameObject Slot2;
    [SerializeField]public GameObject Slot4;
    [SerializeField]public GameObject Regresar;

    [SerializeField]public InputField Nombre;
    [SerializeField]public GameObject SlotNombre;


    [SerializeField] Jugador Player;
    


    public void IndicarSlots(){
        

        Slot1.SetActive(true);
        Slot2.SetActive(true);
        Slot3.SetActive(true);
        Slot4.SetActive(true);
        Regresar.SetActive(true);
        continuar.SetActive(false);
        NewGame.SetActive(false);
    
    }
    
    public void MostrarTxt(){
        SlotNombre.SetActive(true);
    }

    public void Volver(){
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        Regresar.SetActive(false);
        continuar.SetActive(true);
        NewGame.SetActive(true);
        Nombre.enabled=false;
        SlotNombre.SetActive(false);
    }

}
