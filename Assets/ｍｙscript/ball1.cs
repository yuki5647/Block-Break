using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball1 : MonoBehaviour {

    
    private int click = 0;
    
    public Rigidbody rb;

    private GameObject scoreText;

    private int score = 0;

    private float visiblePosZ = -60.0f;
    


    // Use this for initialization
    void Start() {
        rb = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.z < this.visiblePosZ)
        {

            
            Destroy(gameObject);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            click += 1;
            
       }
       if (click == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.AddForce(10.0f, 0f, 1000.0f, ForceMode.Force);
            }
        }
    }
    private void OnCollisionEnter(Collision othear)
    {
        if (othear.gameObject.tag == "playertag1")
        {
            rb.AddForce(-50.0f, 0f, -1000.0f, ForceMode.Force);
        }
        if (othear.gameObject.tag == "playertag")
        {
            rb.AddForce(10.0f, 0f, 1000.0f, ForceMode.Force);
        }
        if(othear.gameObject.tag == "blocktag")
        {
            rb.AddForce(10.0f, 0f, -1000.0f, ForceMode.Force);

        }
    }
    }


