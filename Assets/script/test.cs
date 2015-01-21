using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 100, 100), "test"))
        {
            Application.Quit();
        }
    }
}
