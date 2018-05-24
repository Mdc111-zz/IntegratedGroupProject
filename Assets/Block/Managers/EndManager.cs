using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if (BlockManager.Instance.equationBlocks.Count < 1)
        {
            SceneManager.LoadScene(4);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
