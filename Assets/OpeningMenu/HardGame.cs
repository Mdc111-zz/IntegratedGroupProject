using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardGame : MonoBehaviour {

    Button hardButton;

    // Use this for initialization
    void Start() {
        hardButton = gameObject.GetComponent<Button>();
        hardButton.onClick.AddListener(ChangeToSixGrid);
    }
    void ChangeToSixGrid()
    {
        SceneManager.LoadScene(2);
    }
}
