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
        if (SceneManager.GetActiveScene().name.Contains("4"))
            SetupEquationArray(4);
        else
            SetupEquationArray(6);
    }

    public void SetupEquationArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                Debug.Log("in equation setup");
                equationArray = new List<string> { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation" };
                break;
            case 6:
                equationArray = new List<string> { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation"};
                break;
            default: break;
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
