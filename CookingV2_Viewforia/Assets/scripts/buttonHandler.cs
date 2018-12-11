using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class buttonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject button, timerIndicator;

    private static bool OkDown = false, NextDown = false, BackDown = false;


    public static bool okDown()
    {
        if (OkDown)
        {
            OkDown = false;
            return true;
        }

        else
            return false;
    }

    public static bool nextDown()
    {
        if (NextDown)
        {
            NextDown = false;
            return true;
        }

        else
            return false;
    }

    public static bool backDown()
    {
        if (BackDown)
        {
            BackDown = false;
            return true;
        }

        else
            return false;
    }



    void Start ()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);   		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        StartCoroutine("buttonTimer");
    }
    



    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //reset button visual and timer
        StopAllCoroutines();
        timerIndicator.SetActive(false);
        timerIndicator.transform.localScale = new Vector3 (1f, 0.2f, 1f);

        //reset button logic
        OkDown = false; NextDown = false; BackDown = false;
    }

	// Update is called once per frame
	void Update ()

    {
      //  CookingManager.UpdateText("hello");
      
    }

    IEnumerator buttonTimer()
    {
        Vector3 decscale = new Vector3(0.0145f, 0.0f, 0.0145f);

        timerIndicator.SetActive(true);

        for (float f = 7f; f >= 0; f -= 0.1f)
        {
            if (f > 0.1)
            {
                timerIndicator.transform.localScale -= decscale;
       
            }

            else if (f >= 0)
            {
                if (button.name == "ok")
                {
                    OkDown = true;
                }

                if (button.name == "back")
                {
                    BackDown = true;
                }

                if (button.name == "next")
                {
                    NextDown = true;
                }
            }

            yield return false;
        }

    } 

}
