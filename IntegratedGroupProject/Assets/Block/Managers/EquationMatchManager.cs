using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationMatchManager {

    EquationBlock equationBlockScript;
    AnswerBlock answerBlockScript;

	public EquationMatchManager(GameObject equationBlock, GameObject answerBlock)
    {
        equationBlockScript = equationBlock.GetComponent<EquationBlock>();
        answerBlockScript = answerBlock.GetComponent<AnswerBlock>();
        CheckMatch();
    }
    private void DestroyBlocks()
    {
        SelectionManager.instance.CurrentSelection().Deselect();
        SelectionManager.instance.RemoveSelection();
        equationBlockScript.Destroy();
        answerBlockScript.Destroy();
    }

    private void CheckMatch()
    {
        if (equationBlockScript.GetEquation() == answerBlockScript.GetEquation())
            DestroyBlocks();
    }
}
