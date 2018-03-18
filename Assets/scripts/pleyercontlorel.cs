using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pleyercontlorel : MonoBehaviour {
    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();


		
	}
     void FixedUpdate() 
    {
        float moveHorisontal = Input.GetAxis("Horizontal");
        float moveVertical = Input .GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorisontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
