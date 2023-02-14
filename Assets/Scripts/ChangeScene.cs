using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene"); //Cambiar a la escena del juego.
        AudioManager.instance.ClearAudioList();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu"); //Cambiar a la escena del menu.
        AudioManager.instance.ClearAudioList();
    }
    
    public void exit()
    {
        Application.Quit(); //Cerar la aplicación.
    }
}
