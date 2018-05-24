using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    Timer timer;
    void Start()
    {
        timer = GameObject.Find("Manager").GetComponent<Timer>();
    }

    void Update()
    {
        if(timer.GetTime() > 4 && BlockManager.Instance.answerBlocks.Count == 0)
        {
            Debug.Log(BlockManager.Instance.answerBlocks.Count);
            SceneManager.LoadScene(4);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
