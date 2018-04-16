using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMatcher {

    EquationBlock equationBlockScript;
    AnswerBlock answerBlockScript;

    GameObject equationBlock, answerBlock;

	public BlockMatcher(GameObject equationBlock, GameObject answerBlock)
    {
        equationBlockScript = equationBlock.GetComponent<EquationBlock>();
        answerBlockScript = answerBlock.GetComponent<AnswerBlock>();
        this.answerBlock = answerBlock;
        this.equationBlock = equationBlock;
        CheckMatch();
    }
    private void DestroyBlocks()
    {
        equationBlock.transform.DOScale(Vector3.zero, 0.75f);
        answerBlock.transform.DOScale(Vector3.zero, 0.75f);
        SelectionManager.instance.CurrentSelection().Deselect();
        SelectionManager.instance.RemoveSelection();
        equationBlockScript.Destroy(0.75f);
        answerBlockScript.Destroy(0.75f);
    }

    private void CheckMatch()
    {
        if (equationBlockScript.GetEquation() == answerBlockScript.GetEquation())
            DestroyBlocks();
    }
}
