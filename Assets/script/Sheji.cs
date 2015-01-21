using UnityEngine;
using System.Collections;

public class Sheji : MonoBehaviour {

	int speed = 5;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		int x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		int z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (x, 0, z);
		print (x);
	}
}
