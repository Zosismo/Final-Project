using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene("GCV");

        }
        if (Input.GetKey("a"))
        {
            SceneManager.LoadScene("GCV");

        }

    }
}
