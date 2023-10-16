using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public TextMeshProUGUI characterName;
    public int selectedCharacter = 0;


    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("selectedCharacter", 0);
        foreach (GameObject player in characters)
            player.SetActive(false);
        
        characters[selectedCharacter].SetActive(true);
        characterName.text = characters[selectedCharacter].name.ToString();
    }


    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter == characters.Length)
            selectedCharacter = 0;
        characters[selectedCharacter].SetActive(true);
        characterName.text = characters[selectedCharacter].name.ToString();
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
    }

    public void PrevCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = characters.Length - 1;
        }
        characters[selectedCharacter].SetActive(true);
        characterName.text = characters[selectedCharacter].name.ToString();
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(1);
    }
}
