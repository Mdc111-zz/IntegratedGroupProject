using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerModel : MonoBehaviour {

    List<string> answerArray, avaliableAnswers;
    public static AnswerModel instance { get; private set; }


    private void Start()
    {
        instance = this;
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
                                             "2", "4", "6", "8",
                                             "10", "12", "14", "16"};
                break;
            case 8:
                answerArray = new List<string> { "2", "4", "6", "8",
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
    public string GetRandomAnswer()
    {
        return answerArray[Random.Range(0, answerArray.Count)];
    }
    public List<string> GetAnswers()
    {
        return answerArray;
    }
    public List<string> GetAvailableAnswers()
    {
        return avaliableAnswers;
    }
    public void RemoveAvaliblePosition(int removePoint)
    {
        avaliableAnswers.RemoveAt(removePoint);
    }
    //TODO: dont need 2 arrays, one to store.. why storing.. just removed positions so they cant be used again, upon map reset so will lists
    //TODO: when creating blocks you can create a list of blocks afterwards. then access their scripts and get them to have the correct equation/answer
}
