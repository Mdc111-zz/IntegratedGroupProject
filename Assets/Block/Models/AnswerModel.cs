using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerModel : MonoBehaviour {

    List<string> answerArray;
    public static AnswerModel instance { get; private set; }
    
    private void Start()
    {
        instance = this;
        if (SceneManager.GetActiveScene().name.Contains("4"))
            SetupAnswerArray(4);
        else
            SetupAnswerArray(6);
    }
    public void SetupAnswerArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                Debug.Log("in answer setup");
                answerArray = new List<string> { "2", "4", "6", "8",
                                             "2", "4", "6", "8" };
                break;
            case 6:
                answerArray = new List<string> { "2", "4", "6", "8",
                                             "10", "12", "14", "16",
                                             "2", "4", "6", "8",
                                             "10", "12", "14", "16"};
                break;
            default: break;
        }
    }
    public List<string> GetAnswerArray()
    {
        return answerArray;
    }
    public void RemoveAvaliblePosition(int removePoint)
    {
        answerArray.RemoveAt(removePoint);
    }
}
