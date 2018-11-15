using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCrawlerCamera : MonoBehaviour
{
    public GameObject target;
    public float damping = 1;
    Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        offset = transform.position - target.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.position = position;

        transform.LookAt(target.transform.position);
    }
}
