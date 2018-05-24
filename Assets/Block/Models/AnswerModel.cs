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
                answerArray = new List<string> { "4", "16", "3", "6",
                                                "25", "110", "7", "9" };
                break;
            case 6:
                answerArray = new List<string> { "28", "31", "52",
                                                 "-4", "19", "40",
                                                 "144", "81", "45",
                                                 "8", "11", "7"};
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
