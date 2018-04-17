using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationBlock : Block, ISelectable
{
    public SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public string GetEquation()
    {
        return equation;
    }
    public string GetAnswer()
    {
        return answer;
    }
    public void SetEquation(int indexOfEquationArray)
    {
        equation = EquationModel.instance.GetEquationArray()[indexOfEquationArray];
    }
    public void SetAnswer(int indexOfAnswerArray)
    {
        answer = AnswerModel.instance.GetAnswerArray()[indexOfAnswerArray];
    }
    public void SetTextOfBlock()
    {
        //TODO: make the text appear on gameobject
    }
    public IEnumerator Destroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    public void Deselect()
    {
        sprite.color = Color.white;
        gameObject.transform.localScale += new Vector3(-0.5f, -0.5f, 0);
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void Select()
    {
        sprite.color = Color.green;
        gameObject.transform.localScale += new Vector3(0.5f, 0.5f, 0);
    }
}
