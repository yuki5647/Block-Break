using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class block : MonoBehaviour {

    
    // Use this for initialization
    void Start () {

       
        

       
    }
	
	// Update is called once per frame
	void Update () {

        }
    private void OnCollisionEnter(Collision othear)
    {
        
      
        if (othear.gameObject.tag == "balltag")
            {

            
            Destroy(gameObject);
            }
        
        
    }
    
    }
