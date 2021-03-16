using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ball : MonoBehaviour {

    public float speed = 5.0f;
    public Rigidbody myRigidbody;

    private float coefficient = 0.9f;

    private bool isEnd = false;

    private float visiblePosZ = -7f;

    private GameObject GameOvertext;

    private GameObject cleartext;

    public float thrust;

    // Use this for initialization
    void Start () {

        myRigidbody = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            myRigidbody.AddForce(transform.forward * thrust);
        }
    }
}
