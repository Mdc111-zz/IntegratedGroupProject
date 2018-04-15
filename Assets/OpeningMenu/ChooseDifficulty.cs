using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseDifficulty : MonoBehaviour {

    GameObject startMenu, difficultyMenu;
    Button playButton;

	// Use this for initialization
	void Start () {
        startMenu = GameObject.Find("StartMenu");
        difficultyMenu = GameObject.Find("DifficultyMenu");
        playButton = gameObject.GetComponent<Button>();
        playButton.onClick.AddListener(ChangeToDifficultyMenu);
    }
	void ChangeToDifficultyMenu()
    {
        startMenu.SetActive(false);
        difficultyMenu.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
