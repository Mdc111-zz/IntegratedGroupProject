using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

    List<GameObject> blocks;

    GameObject equationBlock;
    GameObject answerBlock;

	// Use this for initialization
	void Start () {
        blocks = new List<GameObject>();
        
        answerBlock = Resources.Load("Prefabs/AnswerBlock", typeof(GameObject)) as GameObject;
        equationBlock = Resources.Load("Prefabs/EquationBlock", typeof(GameObject)) as GameObject;
        CreateBlockPair(4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateBlockPair(int gridSize)
    {
        for(int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                Instantiate(equationBlock, new Vector2(x, y), Quaternion.identity);
                Instantiate(answerBlock, new Vector2(x, y), Quaternion.identity);
            }
        }
    }
    
}
