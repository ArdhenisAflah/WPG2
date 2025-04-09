using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpened { get; private set; }
    public GameObject TypingMinigame;
    public MonoBehaviour[] scriptsToDisable;

    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        Debug.Log("Interacting with Chest");
        if (!CanInteract()) return;
        SetOpened(true);
        // set minigame aktif
        TypingMinigame.SetActive(true);
        // ketika minigame aktif set skrip movement disable
        foreach (MonoBehaviour script in scriptsToDisable)
        {
            script.enabled = false;
        }
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;
    }
}
