using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed = 5.0f, rotSpeed = 5;
	// Use this for initialization
	void Start () 
    {
		//Debug.DrawRay(transform.position, transform.forward * 100.0f, Color.blue);
	}
	
	// Update is called once per frame
	void Update () 
    {
		Debug.DrawRay(transform.position, transform.forward * 1.0f, Color.blue);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
            if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotSpeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
        }
	}
}
