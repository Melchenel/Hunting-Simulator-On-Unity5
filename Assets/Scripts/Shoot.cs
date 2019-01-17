using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Rigidbody Arrow;
    private Rigidbody NewArrow;
    private float Timer;
    public float Reload;
    public int speed = 20;

	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && Timer<=0)
        {
            NewArrow = Instantiate(Arrow, transform.position, transform.rotation) as Rigidbody;
            NewArrow.AddForce(transform.forward * speed);
            Timer = Reload;
                
        }
	}
}
