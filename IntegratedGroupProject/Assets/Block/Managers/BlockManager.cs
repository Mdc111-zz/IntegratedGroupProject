using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {
    
    GameObject equationBlock;
    GameObject answerBlock;

	// Use this for initialization
	void Start () {
        
        answerBlock = Resources.Load("Prefabs/AnswerBlock", typeof(GameObject)) as GameObject;
        equationBlock = Resources.Load("Prefabs/EquationBlock", typeof(GameObject)) as GameObject;
        //CreateBlockPair(4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateBlockPair(int gridSize)
    {
        for(int x = 0; x < gridSize / 2; x++)
        {
            int randomSpawnPoint = Random.Range(0, gridSize);
            BuildBlock(equationBlock);
            BuildBlock(answerBlock);
        }
    }
    void BuildBlock(GameObject prefab)
    {
        int randomSpawnPoint = Random.Range(0, SpawnPositions.instance.GetAvailableSpawnPoints().Count);
        Instantiate(prefab, SpawnPositions.instance.GetAvailableSpawnPoints()[randomSpawnPoint], Quaternion.identity);
        SpawnPositions.instance.RemoveAvaliblePosition(randomSpawnPoint);
    }
}
