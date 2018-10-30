using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    public float moveSpeed;

	// Use this for initialization
	void Start () 
    {
        moveSpeed = 1f;

        print("What is this place? What am I? Who am I?");	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);	

    }
}
