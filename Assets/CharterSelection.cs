using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharterSelection : MonoBehaviour
{

    public GameObject[] AllCharacters;
    int count = 0;
    private void Start()
    {
        PlayerPrefs.SetInt("player", 0);
    }

    public void NextCharacter()
    {
        count++;
       if(count>=AllCharacters.Length)
        {
           count = AllCharacters.Length-1;
           
        }
       for(int i=0;i<AllCharacters.Length;i++)
        {
            AllCharacters[i].SetActive(false);
        }

        PlayerPrefs.SetInt("player", count);
        AllCharacters[count].SetActive(true);
    }
    public void PreviousCharacter()
    {
        count--;
        for (int i = 0; i < AllCharacters.Length; i++)
        {
            AllCharacters[i].SetActive(false);
        }
        if (count <0)
        {
            count = 0;

            
        }
        PlayerPrefs.SetInt("player", count);

        AllCharacters[count].SetActive(true);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
