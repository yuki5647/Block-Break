using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
    public float speed = 5.0f;
    public float gravity;
    public float Speed;
    public float rotatespeed;


    private bool isEnd = false;
    private GameObject stateText;
    private GameObject scoretext;
    private CharacterController characterController;




    // Use this for initialization
    void Start () {
        this.stateText = GameObject.Find("GameResultText");

        this.scoretext = GameObject.Find("Scoretext");

        characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 35)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -35)
                this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
