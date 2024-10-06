using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{


    // Add or remove an InteractionEvent component to this game object
    public bool useEvents;

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
