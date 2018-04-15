using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyGame : MonoBehaviour {

    Button easyButton;

    // Use this for initialization
    void Start(){
        easyButton = gameObject.GetComponent<Button>();
        easyButton.onClick.AddListener(ChangeToFourGrid);
    }
    void ChangeToFourGrid()
    {
        SceneManager.LoadScene(1);
    }
}
