using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGanerator : MonoBehaviour {

    public Transform targetPrefab;
    public int placex;
    public int placey;
    public int placez;



    // Use this for initialization
    public void Start() {
        Vector3 placePosition = new Vector3(-6, 1 , 23);
        Quaternion a = new Quaternion();
        a = Quaternion.identity;

        for (int i = 0; i < placez; i++)
        {
            Vector3 AcorrentPosition = placePosition - Vector3.forward * targetPrefab.localScale.z * i;

            for (int t = 0; t < placey; t++)
            {
                Vector3 BcorrentPosition = placePosition + Vector3.up * targetPrefab.localScale.y * t;

                for (int j = 0; j < placex; j++)
                {
                    Vector3 CcorrentPosition = placePosition + Vector3.right * targetPrefab.localScale.x * j;

                    Vector3 correntPosition = placePosition + AcorrentPosition + BcorrentPosition + CcorrentPosition;

                    Instantiate(targetPrefab, correntPosition, a)  ;
                     
                    targetPrefab.name =   "Z" + i + "Y" + t + "X" + j;
                        }
            }
        }
    }
    
	
	// Update is called once per frame
	void Update () {
        
    }

}
