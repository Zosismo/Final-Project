using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Bad : MonoBehaviour {
    public AudioClip deathsound;
    public AudioMixer mix;

    public GameObject evilCreator;
    int numFrames = 0;
    int t ;
    int a;
    int b;
    int c;

    float value;
    // Use this for initialization
    void Start () {
        t = Random.Range(20,100 );
        a = Random.Range(70, 100);
        b = Random.Range(100, 150);
        c = Random.Range(200, 250);
    }
	
	// Update is called once per frame
	void Update () {

       


        mix.GetFloat("Pitch", out value);
        Debug.Log(value);
        Debug.Log(t);
        if(value == 1.6f){
           
            t = a;

        }
        if (value == 2f)
        {

            t = b;

        }
        if (value == 0.6f)
        {

            t = c;

        }
        if (numFrames % t == 0)
        {
            GameObject evilInst = Instantiate(evilCreator);
            evilInst.transform.position = this.transform.position;
//            evilInst.transform.position = new Vector3(0, 0, 0);


        }


        StartCoroutine("FadeAlter");



        numFrames++;
    }

   

    IEnumerator FadeAlter()
    {
        int sign = -1;
        while(true){
            for (float f = 1f; f >= 0; f -= 0.1f)
            {

                Vector3 moveLeft = new Vector3(sign*0.001f, 0, 0);
                gameObject.transform.Translate(moveLeft);

            }
            sign *= -1;
            yield return new WaitForSeconds(1.5f);
        }

    }

  
}
