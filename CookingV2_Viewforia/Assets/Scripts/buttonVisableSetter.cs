using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonVisableSetter : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Main.buttonsVisable = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
   
       
	}

    void OnDisable()
    {
        Main.buttonsVisable = false;
    }

    void OnEnable()
    {
        Main.buttonsVisable = true;
    }


}
