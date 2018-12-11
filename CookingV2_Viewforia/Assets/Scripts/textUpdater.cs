using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine;

public class textUpdater : MonoBehaviour {


    public static string freshText;
    string currentText;

    // Use this for initialization
    void Start()
    {
        updateText("start");
    }	
	
	// Update is called once per frame
	void Update ()
    {
        // if the text has changed, run the update function
        if (freshText != currentText)
        {
            currentText = freshText;
            updateText(currentText);
        }

	}

    void updateText(string newText)
    {
        TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        t.text = newText;
    }

    // static member for updating text safley
    public static void UpdateText(string text)
    {
        freshText = text;
    }
}
