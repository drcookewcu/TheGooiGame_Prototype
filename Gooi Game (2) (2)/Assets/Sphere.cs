using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        print("What is this place? What am I? Who am I?");	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);	

    }
}
