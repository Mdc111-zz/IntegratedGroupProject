using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerModel : MonoBehaviour {
    
    public string[] AnswerArray;
    public static AnswerModel instance { get; private set; }


    private void Start()
    {
        instance = this;
    }
    public string GetRandomAnswer()
    {
        return AnswerArray[Random.Range(0, AnswerArray.Length)];
    }
    public void SetupAnswerArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                AnswerArray = new string[] { "2", "4", "6", "8",
                                             "2", "4", "6", "8" };
                break;
            case 6:
                AnswerArray = new string[] { "2", "4", "6", "8",
                                             "10", "12", "14", "16",
                                             "2", "4", "6", "8",
                                             "10", "12", "14", "16"};
                break;
            case 8:
                AnswerArray = new string[] { "2", "4", "6", "8",
                                             "10", "12", "14", "16",
                                             "2", "4", "6", "8",
                                             "10", "12", "14", "16",
                                             "2", "4", "6", "8",
                                             "10", "12", "14", "16",
                                             "2", "4", "6", "8",
                                             "10", "12", "14", "16" };
                break;
            default: break;
        }
    }
}
