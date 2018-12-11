using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonVisableSetter : MonoBehaviour {

    public GameObject myself;
    private MeshRenderer mr;

	void Start ()
    {
        mr = myself.GetComponent<MeshRenderer>();

        Main.buttonsVisable = true;
    }
	
	// Update is called once per frame
	void Update ()
    {           
        if (mr.enabled) Main.buttonsVisable = true;
        else Main.buttonsVisable = false;
    }
}
