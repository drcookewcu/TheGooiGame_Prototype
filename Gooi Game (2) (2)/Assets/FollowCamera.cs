using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    public float damping = 8;
    Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        offset = target.transform.position - transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = target.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);

        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);

        /*transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, -.5, .5),
        Mathf.Clamp(transform.position.y, -.5, .5));*/
    }
}

