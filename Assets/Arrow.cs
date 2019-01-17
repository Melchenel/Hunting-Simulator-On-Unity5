using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
    public Rigidbody arr;
	// Use this for initialization
	void Start () {
        //arr.centerOfMass = (Rigidbody)Vector3(0,0,5);

	}
	
	// Update is called once per frame
	void Update () {
        

	}

	private void OnCollisionEnter(Collision collision)
	{
        arr.isKinematic = true;
        arr.transform.parent = collision.transform;
	}
}
