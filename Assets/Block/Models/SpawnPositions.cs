using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPositions : MonoBehaviour {
    
    public static SpawnPositions instance { get; private set; }
    List<Vector3> gameGrid;

    // Use this for initialization
    void Start () {
        instance = this;
        if (SceneManager.GetActiveScene().name.Contains("4"))
            SetupSpawnPositionArray(4);
        else
            SetupSpawnPositionArray(6);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetupSpawnPositionArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                Debug.Log("in spawn pos setup");
                gameGrid = new List<Vector3> { new Vector3(-1.5f, 1.5f, 0), new Vector3(-0.5f, 1.5f, 0), new Vector3(0.5f, 1.5f, 0), new Vector3(1.5f, 1.5f, 0),
                                           new Vector3(-1.5f, 0.5f, 0), new Vector3(-0.5f, 0.5f, 0), new Vector3(0.5f, 0.5f, 0), new Vector3(1.5f, 0.5f, 0),
                                           new Vector3(-1.5f, -0.5f, 0), new Vector3(-0.5f, -0.5f, 0), new Vector3(0.5f, -0.5f, 0), new Vector3(1.5f, -0.5f, 0),
                                           new Vector3(-1.5f, -1.5f, 0), new Vector3(-0.5f, -1.5f, 0), new Vector3(0.5f, -1.5f, 0), new Vector3(1.5f, -1.5f, 0)
                };
                break;
            case 6:
                gameGrid = new List<Vector3> {  new Vector3(-2.5f, 2.5f, 0), new Vector3(-1.5f, 2.5f, 0), new Vector3(-0.5f, 2.5f, 0), new Vector3(0.5f, 2.5f, 0), new Vector3(1.5f, 2.5f, 0), new Vector3(2.5f, 2.5f, 0),
                                                new Vector3(-2.5f, 1.5f, 0), new Vector3(-1.5f, 1.5f, 0), new Vector3(-0.5f, 1.5f, 0), new Vector3(0.5f, 1.5f, 0), new Vector3(1.5f, 1.5f, 0), new Vector3(2.5f, 1.5f, 0),
                                                new Vector3(-2.5f, 0.5f, 0), new Vector3(-1.5f, 0.5f, 0), new Vector3(-0.5f, 0.5f, 0), new Vector3(0.5f, 0.5f, 0), new Vector3(1.5f, 0.5f, 0), new Vector3(2.5f, 0.5f, 0),
                                                new Vector3(-2.5f, -0.5f, 0), new Vector3(-1.5f, -0.5f, 0), new Vector3(-0.5f, -0.5f, 0), new Vector3(0.5f, -0.5f, 0), new Vector3(1.5f, -0.5f, 0), new Vector3(2.5f, -0.5f, 0),
                                                new Vector3(-2.5f, -1.5f, 0), new Vector3(-1.5f, -1.5f, 0), new Vector3(-0.5f, -1.5f, 0), new Vector3(0.5f, -1.5f, 0), new Vector3(1.5f, -1.5f, 0), new Vector3(2.5f, -1.5f, 0),
                                                new Vector3(-2.5f, -2.5f, 0), new Vector3(-1.5f, -2.5f, 0), new Vector3(-0.5f, -2.5f, 0), new Vector3(0.5f, -2.5f, 0), new Vector3(1.5f, -2.5f, 0), new Vector3(2.5f, -2.5f, 0)
                };
                break;
            default:
                gameGrid = new List<Vector3>();
                break;
        }
    }
    public List<Vector3> GetGameGrid()
    {
        return gameGrid;
    }
    public void RemoveAvaliblePosition(int removePoint)
    {
        gameGrid.RemoveAt(removePoint);
    }
}
