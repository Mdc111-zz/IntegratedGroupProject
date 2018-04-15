using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositions : MonoBehaviour {
    
    public static SpawnPositions instance { get; private set; }
    List<Vector3> gameGrid, availableSpawnPoints;

    // Use this for initialization
    void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetupEquationArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                gameGrid = new List<Vector3> { new Vector3(-1.5f, 1.5f, 0), new Vector3(-0.5f, 1.5f, 0), new Vector3(0.5f, 1.5f, 0), new Vector3(1.5f, 1.5f, 0),
                                           new Vector3(-1.5f, 0.5f, 0), new Vector3(-0.5f, 0.5f, 0), new Vector3(0.5f, 0.5f, 0), new Vector3(1.5f, 0.5f, 0),
                                           new Vector3(-1.5f, -0.5f, 0), new Vector3(-0.5f, -0.5f, 0), new Vector3(0.5f, -0.5f, 0), new Vector3(1.5f, -0.5f, 0),
                                           new Vector3(-1.5f, -1.5f, 0), new Vector3(-0.5f, -1.5f, 0), new Vector3(0.5f, -1.5f, 0), new Vector3(1.5f, -1.5f, 0)
                };
                availableSpawnPoints = gameGrid;
                break;
            case 6:
                gameGrid = new List<Vector3> {  new Vector3(-2.5f, 2.5f, 0), new Vector3(-1.5f, 2.5f, 0), new Vector3(-0.5f, 2.5f, 0), new Vector3(0.5f, 2.5f, 0), new Vector3(1.5f, 2.5f, 0), new Vector3(2.5f, 2.5f, 0),
                                            new Vector3(-2.5f, 1.5f, 0), new Vector3(-1.5f, 1.5f, 0), new Vector3(-0.5f, 1.5f, 0), new Vector3(0.5f, 1.5f, 0), new Vector3(1.5f, 1.5f, 0), new Vector3(2.5f, 2.5f, 0),
                                            new Vector3(-2.5f, 0.5f, 0), new Vector3(-1.5f, 0.5f, 0), new Vector3(-0.5f, 0.5f, 0), new Vector3(0.5f, 0.5f, 0), new Vector3(1.5f, 0.5f, 0), new Vector3(2.5f, 2.5f, 0),
                                            new Vector3(-2.5f, -0.5f, 0), new Vector3(-1.5f, -0.5f, 0), new Vector3(-0.5f, -0.5f, 0), new Vector3(0.5f, -0.5f, 0), new Vector3(1.5f, -0.5f, 0), new Vector3(2.5f, 2.5f, 0),
                                            new Vector3(-2.5f, -1.5f, 0), new Vector3(-1.5f, -1.5f, 0), new Vector3(-0.5f, -1.5f, 0), new Vector3(0.5f, -1.5f, 0), new Vector3(1.5f, -1.5f, 0), new Vector3(2.5f, 2.5f, 0),
                                            new Vector3(-2.5f, -2.5f, 0), new Vector3(-1.5f, -2.5f, 0), new Vector3(-0.5f, -1.5f, 0), new Vector3(0.5f, -2.5f, 0), new Vector3(1.5f, -1.5f, 0), new Vector3(2.5f, 2.5f, 0)
                };
                availableSpawnPoints = gameGrid;
                break;
            case 8:
                gameGrid = new List<Vector3> { new Vector3(-3.5f, 3.5f, 0), new Vector3(-2.5f, 3.5f, 0), new Vector3(-1.5f, 3.5f, 0), new Vector3(-0.5f, 3.5f, 0), new Vector3(0.5f, 3.5f, 0), new Vector3(1.5f, 3.5f, 0), new Vector3(2.5f, 3.5f, 0), new Vector3(3.5f, 3.5f, 0),
                                           new Vector3(-3.5f, 2.5f, 0), new Vector3(-2.5f, 2.5f, 0), new Vector3(-1.5f, 2.5f, 0), new Vector3(-0.5f, 2.5f, 0), new Vector3(0.5f, 2.5f, 0), new Vector3(1.5f, 2.5f, 0), new Vector3(2.5f, 2.5f, 0), new Vector3(3.5f, 2.5f, 0),
                                           new Vector3(-3.5f, 1.5f, 0), new Vector3(-2.5f, 1.5f, 0), new Vector3(-1.5f, 1.5f, 0), new Vector3(-0.5f, 1.5f, 0), new Vector3(0.5f, 1.5f, 0), new Vector3(1.5f, 1.5f, 0), new Vector3(2.5f, 1.5f, 0), new Vector3(3.5f, 1.5f, 0),
                                           new Vector3(-3.5f, 0.5f, 0), new Vector3(-2.5f, 0.5f, 0), new Vector3(-1.5f, 0.5f, 0), new Vector3(-0.5f, 0.5f, 0), new Vector3(0.5f, 0.5f, 0), new Vector3(1.5f, 0.5f, 0), new Vector3(2.5f, 0.5f, 0), new Vector3(3.5f, 0.5f, 0),
                                           new Vector3(-3.5f, -0.5f, 0), new Vector3(-2.5f, -0.5f, 0), new Vector3(-1.5f, -0.5f, 0), new Vector3(-0.5f, -0.5f, 0), new Vector3(0.5f, -0.5f, 0), new Vector3(1.5f, -0.5f, 0), new Vector3(2.5f, -0.5f, 0), new Vector3(3.5f, -0.5f, 0),
                                           new Vector3(-3.5f, -1.5f, 0), new Vector3(-2.5f, -1.5f, 0), new Vector3(-1.5f, -1.5f, 0), new Vector3(-0.5f, -1.5f, 0), new Vector3(0.5f, -1.5f, 0), new Vector3(1.5f, -1.5f, 0), new Vector3(2.5f, -1.5f, 0), new Vector3(3.5f, -1.5f, 0),
                                           new Vector3(-3.5f, -2.5f, 0), new Vector3(-2.5f, -2.5f, 0), new Vector3(-1.5f, -2.5f, 0), new Vector3(-0.5f, -2.5f, 0), new Vector3(0.5f, -2.5f, 0), new Vector3(1.5f, -2.5f, 0), new Vector3(2.5f, -2.5f, 0), new Vector3(3.5f, -2.5f, 0),
                                           new Vector3(-3.5f, -3.5f, 0), new Vector3(-2.5f, -3.5f, 0), new Vector3(-1.5f, -3.5f, 0), new Vector3(-0.5f, -3.5f, 0), new Vector3(0.5f, -3.5f, 0), new Vector3(1.5f, -3.5f, 0), new Vector3(2.5f, -3.5f, 0), new Vector3(3.5f, -3.5f, 0)
                };
                availableSpawnPoints = gameGrid;
                break;
            default: break;
        }
    }
    public List<Vector3> GetGameGrid()
    {
        return gameGrid;
    }
    public List<Vector3> GetAvailableSpawnPoints()
    {
        return availableSpawnPoints;
    }
    public void RemoveAvaliblePosition(int removePoint)
    {
        availableSpawnPoints.RemoveAt(removePoint);
    }
}
