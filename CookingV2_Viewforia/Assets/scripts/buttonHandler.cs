using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class buttonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject button;

	// Use this for initialization
	void Start () {

        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
   		
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("ok!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("nope");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
