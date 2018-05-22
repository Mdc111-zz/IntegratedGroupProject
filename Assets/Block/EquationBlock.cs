using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquationBlock : Block, ISelectable
{
    public SpriteRenderer sprite;
    public GameObject meshTextTest;

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
        meshTextTest.GetComponent<TextMesh>().text = GetEquation().ToString();
    }
    public IEnumerator Destroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    public void Deselect()
    {
        sprite.color = Color.white;
        gameObject.transform.localScale += new Vector3(-0.5f, -0.5f, 1);
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
