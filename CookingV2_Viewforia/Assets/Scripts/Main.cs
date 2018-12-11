using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Main : MonoBehaviour {

    public static bool buttonsVisable = false;
    
    public GameObject buttonBoard;
    ImageTarget buttons;

    

	void Start ()
    {
        buttons = buttonBoard.GetComponent<ImageTarget>();


        textUpdater.UpdateText("Hey! I Hear you want to learn how to cook. " +
            "\r\n first, you're going to need to look at the controls" +
            "\r\n (..aim the app at the virtual buttons..");

       
	}
	
	// Update is called once per frame
	void Update ()
    {
        

        if (buttonsVisable)
        {
            textUpdater.UpdateText("Hey! I Hear you want to learn how to cook. " +
            "\r\n first, you're going to need to look at the controls" +
            "\r\n good! \r\n now press O to continue.");

        }
           		
	}


}
