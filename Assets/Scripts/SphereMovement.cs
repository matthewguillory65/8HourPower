using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {
    Rigidbody rigidBody;
    public float speed;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }


	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 moveMent = new Vector3(moveHorizontal, 0.0F, moveVertical);
        rigidBody.AddForce(moveMent * speed);
    }
}
