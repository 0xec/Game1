using UnityEngine;
using System.Collections;

public class pzjc : MonoBehaviour {
    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    
    void OnCollisionEnter(Collision collision){
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
        //Destroy(gameObject);
    }
}
