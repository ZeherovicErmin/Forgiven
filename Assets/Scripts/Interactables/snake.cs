using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class snake : Interactable
{

    [SerializeField]
    private GameObject GregSon;
    
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
        UnityEngine.Debug.Log("Interacted with " + gameObject.name);
    }
}
