using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilCreator : MonoBehaviour {

    public GameObject evilCreator;
    int numFrames = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(numFrames %200 == 0){
            GameObject evilInst = Instantiate(evilCreator);

            //evilInst.transform.position = new Vector3(0, 0, 0);
            evilInst.transform.parent = transform.parent;

        }
     

        numFrames++;
    }
}
