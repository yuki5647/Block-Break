using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {

    

    private Animator Animator;

	// Use this for initialization
	void Start () {
        Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Animator.SetBool("Hikick", true);
        }
	}
}
