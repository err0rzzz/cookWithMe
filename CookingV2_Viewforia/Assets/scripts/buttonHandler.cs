using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class buttonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject button;

	// Use this for initialization
	void Start () {
       // button = GameObject.Find("bttn_ok");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
   		
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (button.name == "ok")
        {
            Debug.Log("ok!");
        }

        if (button.name == "back")
        {
            Debug.Log("back");
        }

        if (button.name == "next")
        {
            Debug.Log("next");
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("nope");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
