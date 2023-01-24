using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFakeforLevls : MonoBehaviour
{

   public void Level1()
    {
        SceneManager.LoadScene("GamePlay");
    }


   public void Level2()
    {
   
        SceneManager.LoadScene("GamePlay2");
    }



    public void Level3()
    {

        SceneManager.LoadScene("GamePlay3");
    }


    public void QuitApplication()
    {
        Application.Quit();
    }
}
