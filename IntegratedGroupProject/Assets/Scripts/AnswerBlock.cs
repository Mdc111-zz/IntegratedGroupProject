using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBlock : Block, ISelectable
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
    private void SetEquation()
    {
        equation = EquationModel.instance.GetRandomEquation();
    }
    private void SetAnswer()
    {
        equation = AnswerModel.instance.GetRandomAnswer();
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
