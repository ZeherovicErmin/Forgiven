using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Door : Interactable
{

    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function where the interaction is designed utilizing code

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
