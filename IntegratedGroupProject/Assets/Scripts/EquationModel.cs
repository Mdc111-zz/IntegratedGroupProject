using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationModel : MonoBehaviour {

    public string[] EquationArray;
    public static EquationModel instance { get; private set; }

    private void Start()
    {
        instance = this;
    }
    public string GetRandomEquation()
    {
        return EquationArray[Random.Range(0, EquationArray.Length)];
    }
    public void SetupEquationArray(int gridsize)
    {
        switch (gridsize)
        {
            case 4:
                EquationArray = new string[] { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation" };
        
                break;
            case 6:
                EquationArray = new string[] { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation"};
                break;
            case 8:
                EquationArray = new string[] { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation" };
                break;
            default: break;
        }
    }
}
