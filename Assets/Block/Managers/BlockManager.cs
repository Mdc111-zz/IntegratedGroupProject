using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockManager : MonoBehaviour {
    
    GameObject equationBlockPrefab;
    GameObject answerBlockPrefab;

    List<EquationBlock> equationBlocks;
    List<AnswerBlock> answerBlocks;

    // Use this for initialization
    void Start () {
        equationBlocks = new List<EquationBlock>();
        answerBlocks = new List<AnswerBlock>();

        answerBlockPrefab = Resources.Load("Prefabs/AnswerBlock", typeof(GameObject)) as GameObject;
        equationBlockPrefab = Resources.Load("Prefabs/EquationBlock", typeof(GameObject)) as GameObject;
        //CreateBlockPair(4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateBlockGrid(int gridSize)
    {
        for(int x = 0; x < gridSize / 2; x++)
        {
            BuildBlock(equationBlockPrefab);
            BuildBlock(answerBlockPrefab);
        }
        SetupEquationBlocks();
        SetupAnswerBlocks();
    }
    void BuildBlock(GameObject prefab)
    {
        int randomSpawnPoint = Random.Range(0, SpawnPositions.instance.GetGameGrid().Count);
        Instantiate(prefab, SpawnPositions.instance.GetGameGrid()[randomSpawnPoint], Quaternion.identity);
        SpawnPositions.instance.RemoveAvaliblePosition(randomSpawnPoint);
    }
    void SetupEquationBlocks()
    {
        equationBlocks = FindObjectsOfType<EquationBlock>().ToList();
        for (int i = 0; i < equationBlocks.Count; i++)
        {
            equationBlocks[i].SetAnswer(i);
            equationBlocks[i].SetEquation(i);
            equationBlocks[i].SetTextOfBlock();
        }
    }
    void SetupAnswerBlocks()
    {
        answerBlocks = FindObjectsOfType<AnswerBlock>().ToList();
        for (int i = 0; i < answerBlocks.Count; i++)
        {
            answerBlocks[i].SetAnswer(i);
            answerBlocks[i].SetEquation(i);
            answerBlocks[i].SetTextOfBlock();
        }
    }
}
