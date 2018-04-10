using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour, ISelectionManager{
    private ISelectable selection;
    public static ISelectionManager instance { get; private set; }

    public void Start()
    {
        instance = this;
    }
    public ISelectable CurrentSelection()
    {
        return selection;
    }
    public void Select(ISelectable selection)
    {
        this.selection = selection;
    }
    public void RemoveSelection()
    {
        selection = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.GetComponent<EquationBlock>() != null)
            {
                if (selection != null)
                    selection.Deselect();
                selection = hit.collider.GetComponent<ISelectable>();
                selection.Select();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.GetComponent<AnswerBlock>() != null && CurrentSelection().GetGameObject().GetComponent<EquationBlock>() != null)
            {
                if (selection != null)
                    selection.Deselect();
                selection = hit.collider.GetComponent<ISelectable>();
                selection.Select();
            }
        }
    }
}
