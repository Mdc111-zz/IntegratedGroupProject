using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EquationModel : MonoBehaviour {

    List<string> equationArray;    
    public static EquationModel instance { get; private set; }

    private void Start()
    {
        instance = this;
        if (SceneManager.GetActiveScene().name.Contains("6"))
            SetupEquationArray(6);
        else
            SetupEquationArray(4);
    }

    public void SetupEquationArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                equationArray = new List<string> { "2 + 2", "9 + 7", "9 - 6", "20 - 14",
                                                   "5 * 5", "11 * 10", "49 / 7", "27 / 3" };
                break;
            case 6:
                equationArray = new List<string> { "11 + 17", "25 + 6", "37 + 14",
                                                   "38 - 42", "31 - 12", "75 - 35",
                                                   "12 * 12", "9 * 9", "5 * 9",
                                                   "64 / 8", "55 / 5", "77 / 11"};

                break;
            default:
                equationArray = new List<string>();
                break;
        }
    }
    public List<string> GetEquationArray()
    {
        return equationArray;
    }
    public void RemoveAvaliblePosition(int removePoint)
    {
        equationArray.RemoveAt(removePoint);
    }
}
