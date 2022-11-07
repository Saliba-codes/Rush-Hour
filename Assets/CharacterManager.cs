using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public TMP_Text nameText;
    public SpriteRenderer artworkSprite;
    public Animator artworkAnimator;

    private int selectedOption = 0;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        
        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        
        UpdateCharacter(selectedOption);
        Save();
    }

    public void PreviousOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }
        
        UpdateCharacter(selectedOption);
        Save();
    }

    void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite.GetComponent<SpriteRenderer>().sprite;
        artworkAnimator.runtimeAnimatorController = character.characterSprite.GetComponent<Animator>().runtimeAnimatorController;
        gameObject.transform.rotation = character.characterSprite.transform.rotation;
        nameText.text = character.characterName;
    }

    void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void ChangeScene(int SceneID)
{
        SceneManager.LoadScene(SceneID);
}
}