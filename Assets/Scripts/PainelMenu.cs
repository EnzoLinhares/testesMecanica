using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PainelMenu : MonoBehaviour
{

    void Start()
    {
        
   


    }

    public void StartGame (){

        SceneManager.LoadScene(1);
    }

    public void OpenOptions(){

    }

    public void CloseOptions(){

    }

    public void CloseGame(){

        Application.Quit();
        Debug.Log("saiu do jogo");
    }
}
