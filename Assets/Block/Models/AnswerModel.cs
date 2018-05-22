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
        if (SceneManager.GetActiveScene().name.Contains("6"))
            SetupAnswerArray(6);
        else
            SetupAnswerArray(4);
    }
    public void SetupAnswerArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                answerArray = new List<string> { "2", "4", "6", "8",
                                                "2", "4", "6", "8" };
                break;
            case 6:
                answerArray = new List<string> { "2", "4", "6", "8",
                                                 "10", "12", "14", "16",
                                                 "2", "4", "6", "8"};
                break;
            default:
                answerArray = new List<string>();
                break;
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
