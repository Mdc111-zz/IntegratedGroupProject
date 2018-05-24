using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour {

    Button quitButton;

	// Use this for initialization
	void Start ()
    {
        quitButton = gameObject.GetComponent<Button>();
        quitButton.onClick.AddListener(QuitApplication);

    }
	void QuitApplication()
    {
        Application.Quit();
    }
}
