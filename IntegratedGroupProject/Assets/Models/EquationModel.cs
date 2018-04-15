using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationModel : MonoBehaviour {

    List<string> equationArray, avaliableEquations;    
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
                avaliableEquations = equationArray;
                break;
            case 6:
                equationArray = new List<string> { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation"};
                avaliableEquations = equationArray;
                break;
            case 8:
                equationArray = new List<string> { "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation",
                                               "Equation", "Equation", "Equation", "Equation" };
                avaliableEquations = equationArray;
                break;
            default: break;
        }
    }
    public string GetRandomEquation()
    {
        return equationArray[Random.Range(0, equationArray.Count)];
    }
    public List<string> GetEquationArray()
    {
        return equationArray;
    }

}
