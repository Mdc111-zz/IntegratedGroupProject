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
                equationArray = new List<string> { "2 + 2", "Equation", "Equation", "Equation",
                                                   "Equation", "Equation", "Equation", "Equation" };
                break;
            case 6:
                equationArray = new List<string> { "2 + 2", "Equation", "Equation", "Equation",
                                                   "Equation", "Equation", "Equation", "Equation",
                                                   "Equation", "Equation", "Equation", "Equation"};
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
