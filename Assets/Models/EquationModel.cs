using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationModel : MonoBehaviour {

    List<string> equationArray;    
    public static EquationModel instance { get; private set; }

    private void Start()
    {
        instance = this;
    }

    public void SetupEquationArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
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
