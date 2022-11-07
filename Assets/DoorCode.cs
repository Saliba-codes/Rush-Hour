using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCode : MonoBehaviour
{
    public int  ILevelToLoad;
    public string sLevelToLoad;

    public bool useIntegerToLoadLevel = false;
    void Start()
    {
    }
	private void OnTriggerEnter2D(Collider2D  col)
    {
        GameObject collisionGameObject = col.gameObject;

        if ( (collisionGameObject.name == "Soldier") || (collisionGameObject.name == "Ninja")|| (collisionGameObject.name == "Wizard")|| (collisionGameObject.name == "LightBandit"))
        {
            LoadScene();
        } 
    	}

        void LoadScene(){
            if ( useIntegerToLoadLevel){
                SceneManager.LoadScene(ILevelToLoad);
            }
            else
            {
                SceneManager.LoadScene(sLevelToLoad);
            }
        }
    }

