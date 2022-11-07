using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneManaging : MonoBehaviour
{
   public void start()
    {
        SceneManager.LoadScene("Character Selection Pannel");
    }

    public void secret()
    {
        SceneManager.LoadScene("SecretLevelNextPage");
    }


    public void exit()
    {
      UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Good Bye!");
        Application.Quit();
    }

}   