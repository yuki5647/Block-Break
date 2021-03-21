using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour {

    private GameObject scoreText;

    private int score = 0;
    
    // Use this for initialization
    void Start () {

        this.scoreText = GameObject.Find("ScoreText");
    }
	
	// Update is called once per frame
	void Update () {

        }
    private void OnCollisionEnter(Collision othear)
    {

        if (othear.gameObject.tag == "balltag")
        {
            
                this.score += 100;
                this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
            
            Destroy(gameObject);
        }
        
    }
    
    }
