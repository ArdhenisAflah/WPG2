using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpened {get; private set;}

    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        Debug.Log("Interacting with Chest");
        if (!CanInteract()) return;
        SetOpened(true);
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;
    }
}
