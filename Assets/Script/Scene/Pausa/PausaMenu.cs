using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaMenu : MonoBehaviour
{
    public GameObject pausemenu;
    bool isPause;
    void Awake()
    {
        Time.timeScale = 1;
        pausemenu.SetActive(false);
        isPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }
    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPause)
        {
            Time.timeScale = 0;
            pausemenu.SetActive(true);
            isPause = true;

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPause)
        {
            Time.timeScale = 1;
            pausemenu.SetActive(false);
            isPause = false;
        }
    }
    public void Continuar()
    {

        Time.timeScale = 1;
        pausemenu.SetActive(false);
        isPause = false;

    }
    public void Reiniciar()
    {

        

    }


}

