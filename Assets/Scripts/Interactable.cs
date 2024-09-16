using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    // Creating a message that displays when the player is looking at an interactable
    public string promptMessage;


    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {

    }



}
