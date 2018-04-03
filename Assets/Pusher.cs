using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pusher : MonoBehaviour {
    Vector3 initPosition;
    Vector3 newPosition;
    float Size = 1.7f;
    // Use this for initialization
    void Start () {
        initPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        newPosition = new Vector3(initPosition.x, initPosition.y, initPosition.z + Size * Mathf.Sin(Time.time));
        this.GetComponent<Rigidbody>().MovePosition(newPosition);
    }
}
