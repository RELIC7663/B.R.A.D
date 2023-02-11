using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarSlots : MonoBehaviour
{

    [SerializeField] public GameObject continuar;
    [SerializeField] public GameObject NewGame;
    [SerializeField] public GameObject Slot1;
    [SerializeField] public GameObject Slot2;
    [SerializeField] public GameObject Slot3;
    [SerializeField] public GameObject Slot4;

    [SerializeField] public GameObject continuarSlot1;
    [SerializeField] public GameObject continuarSlot2;
    [SerializeField] public GameObject continuarSlot3;
    [SerializeField] public GameObject continuarSlot4;

    [SerializeField] public Text TextcontinuarSlot1;
    [SerializeField] public Text TextcontinuarSlot2;
    [SerializeField] public Text TextcontinuarSlot3;
    [SerializeField] public Text TextcontinuarSlot4;

    [SerializeField] public GameObject Regresar;

    [SerializeField] public InputField Nombre;
    [SerializeField] public GameObject SlotNombre;
    [SerializeField] public GameObject borrar;


    [SerializeField] Jugador Player;



    public void IndicarSlots()
    {

        

        Slot1.SetActive(true);
        Slot2.SetActive(true);
        Slot3.SetActive(true);
        Slot4.SetActive(true);
        Regresar.SetActive(true);
        continuar.SetActive(false);
        NewGame.SetActive(false);
        borrar.SetActive(true);

    }

    public void MostrarTxt()
    {
        SlotNombre.SetActive(true);
    }

    public void Volver()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        continuarSlot1.SetActive(false);
        continuarSlot2.SetActive(false);
        continuarSlot3.SetActive(false);
        continuarSlot4.SetActive(false);
        Regresar.SetActive(false);
        continuar.SetActive(true);
        NewGame.SetActive(true);
        SlotNombre.SetActive(false);
        borrar.SetActive(false);
    }
    public void Contuniar()
    {

        sUpdate ();
        

        Regresar.SetActive(true);
        continuar.SetActive(false);
        NewGame.SetActive(false);
        SlotNombre.SetActive(false);
        borrar.SetActive(true);
    }

    private void  sUpdate (){
        
        if (SaveSystem.LoadData(0).Nivelne() != 0)
        {
            TextcontinuarSlot1.text=SaveSystem.LoadData(0).NamePlayer();
            continuarSlot1.SetActive(true);
            
        }
        else continuarSlot1.SetActive(false);
        if (SaveSystem.LoadData(1).Nivelne() != 0)
        {
            TextcontinuarSlot2.text=SaveSystem.LoadData(1).NamePlayer();
            continuarSlot2.SetActive(true);
        }
        else continuarSlot2.SetActive(false);
        if (SaveSystem.LoadData(2).Nivelne() != 0)
        {
            TextcontinuarSlot3.text=SaveSystem.LoadData(2).NamePlayer();
            continuarSlot3.SetActive(true);
        }
        else continuarSlot3.SetActive(false);
        if (SaveSystem.LoadData(3).Nivelne() != 0)
        {
            TextcontinuarSlot4.text=SaveSystem.LoadData(3).NamePlayer();

            continuarSlot4.SetActive(true);
        }
        else continuarSlot4.SetActive(false);
    }




}
