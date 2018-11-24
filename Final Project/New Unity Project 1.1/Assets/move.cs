using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gameObject.CompareTag("ball2.2")){

            this.transform.Translate(new Vector3(0.05f, 0.02f, 0));
        }
        else{ this.transform.Translate(new Vector3(0.05f, 0, 0)); }


    }
}
