using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
	public AudioClip jumpSound;
	public AudioClip walkSound;
    public GameObject evil;
    public GameObject ballCreator;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public AudioMixer mix;
 
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        float px = gameObject.transform.position.x;

		float py = gameObject.transform.position.y;




		if (Input.GetKey ("left")) {
			Vector3 moveLeft = new Vector3 (-0.1f, 0, 0);
			gameObject.transform.Translate (moveLeft);
			GetComponent<SpriteRenderer> ().flipX = false;
			GetComponent<AudioSource> ().clip = walkSound;
		
		}
		if (Input.GetKey ("right")) {
			Vector3 moveLeft = new Vector3 (0.1f, 0, 0);

			gameObject.transform.Translate (moveLeft);
			GetComponent<SpriteRenderer> ().flipX = true;
			GetComponent<AudioSource> ().clip = walkSound;

		}
		if (Input.GetKey ("up")) {
			Vector3 moveLeft = new Vector3 (0, 0.1f, 0);
			gameObject.transform.Translate (moveLeft);
			GetComponent<AudioSource> ().clip = jumpSound;
		}
		if (Input.GetKeyDown ("up")) {
			
			gameObject.GetComponent<AudioSource>().Play();
		}
		if (Input.GetKeyDown ("right")) {

			gameObject.GetComponent<AudioSource>().Play();
		}
		if (Input.GetKeyDown ("left")) {

			gameObject.GetComponent<AudioSource>().Play();

		}
        if (Input.GetKeyUp("up"))
        {

            gameObject.GetComponent<AudioSource>().Stop();
        }
        if (Input.GetKeyUp("right"))
        {

            gameObject.GetComponent<AudioSource>().Stop();
        }
        if (Input.GetKeyUp("left"))
        {

            gameObject.GetComponent<AudioSource>().Stop();

        }




    }
	private void OnCollisionEnter2D (Collision2D collision){
		Debug.Log("I hit" + collision.gameObject.tag);
		if (collision.gameObject.CompareTag ("enemy")) {
			collision.gameObject.GetComponent<AudioSource>().Play();
		}
        if (collision.gameObject.CompareTag("block"))
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
            GameObject ballInst = Instantiate(ballCreator);

            ballInst.transform.position = new Vector3(0, 0, 0);
        }
        if (collision.gameObject.CompareTag("ball1"))
        {
            Debug.Log("I hit" + collision.gameObject.tag);
            Destroy(ball2.gameObject);
            Destroy(ball1.gameObject);
            Destroy(ball3.gameObject);
            mix.SetFloat("Pitch", 1.6f);
        }
        if (collision.gameObject.CompareTag("ball"))
        {
            Debug.Log("I hit" + collision.gameObject.tag);
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");

        }
        if (collision.gameObject.CompareTag("ball2.2"))
        {
            Debug.Log("I hit" + collision.gameObject.tag);
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");

        }
        if (collision.gameObject.CompareTag("ball2"))
        {
            Destroy(ball2.gameObject);
            Destroy(ball1.gameObject);
            Destroy(ball3.gameObject);
            mix.SetFloat("Pitch", 0.6f);
        }
        if (collision.gameObject.CompareTag("ball3"))
        {
            Destroy(ball2.gameObject);
            Destroy(ball1.gameObject);
            Destroy(ball3.gameObject);
            mix.SetFloat("Pitch", 2f);
        }
        if (collision.gameObject.CompareTag("enemy1"))
        {
            Destroy(evil.gameObject);
             SceneManager.LoadScene("Second");
        }
        if (collision.gameObject.CompareTag("enemy2"))
        {
            Destroy(evil.gameObject);
            
            SceneManager.LoadScene("Third");
        }
        if (collision.gameObject.CompareTag("enemy3"))
        {
           Destroy(evil.gameObject);

            SceneManager.LoadScene("End");
        }

    }

}
