using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelected : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] allcharacters;
    void Start()
    {

        allcharacters[PlayerPrefs.GetInt("player", 0)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
