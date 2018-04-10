using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectionManager
{
    void Select(ISelectable selection);
    void RemoveSelection();
    ISelectable CurrentSelection();
}
