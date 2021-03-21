using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball1 : MonoBehaviour {

    public float thrust;
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

            rb.AddForce(transform.forward * thrust);
        }

    }

    void OnTriggerEnter(Collision othear)
    {
        

        if (othear.gameObject.tag == "blocktag")
        {
            this.score += 100;
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";

            Destroy(othear.gameObject);
        }


    }
}

