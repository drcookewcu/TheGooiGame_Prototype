using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject collectible;

    public bool canPickUp = false;

    
	// Use this for initialization
	void Start ()
    {
        collectible.SetActive(true);	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canPickUp)
        {
            collectible.SetActive(false);
            Destroy(collectible);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (tag == "Player")
        {
            canPickUp = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(tag == "Player")
        {
            canPickUp = false;
        }
    }
}
