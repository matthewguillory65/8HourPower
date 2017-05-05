using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public Camera camera;
    private Vector3 offSet;
    private Vector3 onSet;
	// Use this for initialization
	void Start ()
    {
        offSet = camera.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //camera.transform.eulerAngles = transform.position + offSet;
        camera.transform.position = transform.position + offSet;
        //camera.transform.localEulerAngles = transform.position + offSet;
        
    }
}
