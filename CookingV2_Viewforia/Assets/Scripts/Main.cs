using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Main : MonoBehaviour {

    public static bool buttonsVisable = false;
    private int cookStage = 0;


    
    public GameObject buttonBoard;
    ImageTarget buttons;

    

	void Start ()
    {
        buttons = buttonBoard.GetComponent<ImageTarget>();


        textUpdater.UpdateText("Hey! I Hear you want to learn how to cook. " +
            "\r\n first, you're going to need to look at the controls" +
            "\r\n (..aim the app at the virtual buttons..");
        cookStage = 1; //set the program ready to progress

       
	}
	
	// Update is called once per frame
	void Update ()
    {      
        switch (cookStage)
        {

            case 1:
                if (buttonsVisable)
                {
                    textUpdater.UpdateText("Hey! I Hear you want to learn how to cook. " +
                    "\r\n first, you're going to need to look at the controls" +
                    "\r\n good! \r\n now press O to continue.");
                    cookStage = 2;
                }
                return;

            case 2:
                if (buttonHandler.okDown())
                {
                    cookStage = 3;
                }
                return;
            
                //recipe select, cookies 1
            case 3:
                textUpdater.UpdateText ("lets select a recipe \r\n (Use Arrows to select) \r\n **** COOKIES 1 ****");

                if (buttonHandler.nextDown())
                {
                    cookStage = 4;
                }

                if (buttonHandler.backDown())
                {
                    cookStage = 5;
                }
                return;

            //recipe select, cookies 2
            case 4:

                textUpdater.UpdateText("lets select a recipe \r\n (Use Arrows to select) \r\n **** COOKIES 2 ****");
                if (buttonHandler.backDown())
                {
                    cookStage = 3;
                }

                if (buttonHandler.nextDown())
                {
                    cookStage = 5;
                }
                return;

            //recipe select, cookies 3
            case 5:
                textUpdater.UpdateText("lets select a recipe \r\n (Use Arrows to select) \r\n **** COOKIES 3 ****");
                if (buttonHandler.backDown())
                {
                    cookStage = 4;
                }


                if (buttonHandler.nextDown())
                {
                    cookStage = 3;
                }

                return;

        } 	
        
	}    
}
