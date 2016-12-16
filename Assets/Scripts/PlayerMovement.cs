using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Movement();
	}

    void Movement() {
        int move = (int) Input.GetAxisRaw("Horizontal");
        print(move);
    }
}
