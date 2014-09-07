using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	public float speed = 2000;
	public GameObject theBall;
	public AudioClip brickBreak;
	public AudioClip wallBounce;
	public GameObject brick;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -22){ //ball death
			transform.position = GameObject.FindGameObjectWithTag("paddle").transform.position + new Vector3(0,1,0);
			theBall.rigidbody.Sleep ();

			//put a ball back on the paddle after death
			paddle p = GameObject.FindGameObjectWithTag("paddle").GetComponent("paddle") as paddle;
			p.prelaunchBall = gameObject;
		}
	}

	void OnCollisionEnter(Collision colson){
		if(colson.gameObject.tag == "wall"){ //bounce off wall
			audio.PlayOneShot(wallBounce, 0.5f);
		}

		if(colson.gameObject.tag == "block"){ //break a block
			audio.PlayOneShot (brickBreak, 0.5f);

		}
	}
}
