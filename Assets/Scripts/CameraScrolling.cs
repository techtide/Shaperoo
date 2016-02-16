using System;
using UnityEngine;
using System.Collections;

public class CameraScrolling : MonoBehaviour
{
    public float scrollSpeed;
    
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {

	    transform.position = new Vector3(transform.position.x, transform.position.y+scrollSpeed, transform.position.z);
       

	    
	}
}
