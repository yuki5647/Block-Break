using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball1 : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;

    Text scoreText;

    private int score = 0;

    private float visiblePosZ = -60.0f;
    


    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();

        this.scoreText = GameObject.Find("scoreText").GetComponent<Text>();
        this.scoreText.text = "Score" + score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            rb.AddForce(transform.forward * thrust);
        }

        if (this.transform.position.z < this.visiblePosZ)
        {

            
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider othear)
    {
        
            if (this.gameObject.tag == "player")
            {
                rb.AddForce(transform.forward * thrust);
            }

        if (othear.gameObject.tag == "blocktag")
        {
            
            this.score += 100;
            this.scoreText.text = "Score" + score.ToString();
        }

        if (othear.gameObject.tag == "blocktag")
        {


            Destroy(othear.gameObject);
        }


    }
}

