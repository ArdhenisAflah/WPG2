using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // private bool z_Interacted = false;

    // protected override void OnCollided(GameObject collidedObject)
    // {
    //     if (Input.GetKey(KeyCode.E))
    //     {
    //         OnInteract();
    //     }
    // }

    // protected virtual void OnInteract()
    // {
    //     if (!z_Interacted)
    //     {
    //         z_Interacted = true;
    //         Debug.Log("Interated With" + name);
    //     }
    // }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       Debug.Log("Entering interactable zone!");
    }
   

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Leave interactable zone!");
    }
}