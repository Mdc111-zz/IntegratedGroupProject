using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPositions : MonoBehaviour {
    
    public static SpawnPositions instance { get; private set; }
    List<Vector3> gameGrid;


	void Start ()
    {
        instance = this;
        if (SceneManager.GetActiveScene().name.Contains("6"))
            SetupSpawnPositionArray(6);
        else
            SetupSpawnPositionArray(4);
    }

    public void SetupSpawnPositionArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                gameGrid = new List<Vector3> {
                    new Vector3(-3f,  3f, 0), new Vector3(-1f,  3f, 0), new Vector3(1f,  3f, 0), new Vector3(3f,  3f, 0),
                    new Vector3(-3f,  1f, 0), new Vector3(-1f,  1f, 0), new Vector3(1f,  1f, 0), new Vector3(3f,  1f, 0),
                    new Vector3(-3f, -1f, 0), new Vector3(-1f, -1f, 0), new Vector3(1f, -1f, 0), new Vector3(3f, -1f, 0),
                    new Vector3(-3f, -3f, 0), new Vector3(-1f, -3f, 0), new Vector3(1f, -3f, 0), new Vector3(3f, -3f, 0)
                };
                break;
            case 6:
                gameGrid = new List<Vector3> {
                    new Vector3(-5f,  3f, 0), new Vector3(-3f,  3f, 0), new Vector3(-1f,  3f, 0), new Vector3(1f,  3f, 0), new Vector3(3f,  3f, 0), new Vector3(5f,  3f, 0),
                    new Vector3(-5f,  1f, 0), new Vector3(-3f,  1f, 0), new Vector3(-1f,  1f, 0), new Vector3(1f,  1f, 0), new Vector3(3f,  1f, 0), new Vector3(5f,  1f, 0),
                    new Vector3(-5f, -1f, 0), new Vector3(-3f, -1f, 0), new Vector3(-1f, -1f, 0), new Vector3(1f, -1f, 0), new Vector3(3f, -1f, 0), new Vector3(5f, -1f, 0),
                    new Vector3(-5f, -3f, 0), new Vector3(-3f, -3f, 0), new Vector3(-1f, -3f, 0), new Vector3(1f, -3f, 0), new Vector3(3f, -3f, 0), new Vector3(5f, -3f, 0)
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
