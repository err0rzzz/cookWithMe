using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class buttonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject button, timerIndicator;

	// Use this for initialization
	void Start () {
       // button = GameObject.Find("bttn_ok");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
   		
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        StartCoroutine("buttonTimer");


    }



    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        StopAllCoroutines();
        timerIndicator.SetActive(false);
        timerIndicator.transform.localScale = new Vector3 (1f, 0.2f, 1f);
        textUpdater.UpdateText(" ");
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
                    Debug.Log("ok!");
                    textUpdater.UpdateText("ok");
                }

                if (button.name == "back")
                {
                    Debug.Log("back");
                    textUpdater.UpdateText("back");
                }

                if (button.name == "next")
                {
                    Debug.Log("next");
                    textUpdater.UpdateText("next");
                }
            }

            yield return false;
        }

    } 

}
