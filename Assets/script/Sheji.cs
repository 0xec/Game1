using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sheji : MonoBehaviour
{
    public float speed = 5;
    public GameObject thePrefab;
    public float ms = 0;
    public float tick = 0.0f;
    public int shot = 0;
    public float Speed {
        get {
            return speed;
        }
        set {
            speed = value;
        }
    }

    // Use this for initialization
    void Start ()
    {

    }


    // Update is called once per frame
    void Update ()
    {
        float x = Input.GetAxis ("Horizontal") * Time.deltaTime * Speed;
        float z = Input.GetAxis ("Vertical") * Time.deltaTime * Speed;

        if (Input.GetButton ("Fire2")) {
            float rx = Input.GetAxis ("Mouse Y");
            float ry = Input.GetAxis ("Mouse X");

            transform.Rotate(
                rx * Time.deltaTime * 220,
                ry * Time.deltaTime * -220,
                0,
                Space.World);

        }

        Vector3 pos = transform.position;
        if (pos.y < 3.0f) {
            pos.y = 3.0f;
            transform.position = pos;
        }
        transform.Translate (x, 0, z);


        if (Input.GetButton("Fire1")) {
            ms += Time.deltaTime;
            if  (ms > 0.3f) {
                GameObject obj = Instantiate (thePrefab, transform.position, transform.rotation) as GameObject;

                Vector3 fwd = transform.TransformDirection (Vector3.forward);
                obj.rigidbody.AddForce (fwd * 500);

                shot++;
                Text label = GameObject.Find("Text").GetComponent<Text>();
                label.text = "test:" + shot;

               // GUIText control = GameObject.Find("Text") .GetComponent<GUIText>() as GUIText;
               // control.text = "test";

                Destroy(obj, 3.0f);
                ms = 0.0f;
            }
        }
    }
}
