using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	public float paddleSpeed = .5f;
	public float ballSpeed = 2000.0f;
	public int leftBound = -25;
	public int rightBound = 25;
	public GameObject ballPrefab;
	public GameObject prelaunchBall = null;
	public Rigidbody ballBod;
	public AudioClip paddleSound;



	// Use this for initialization
	void Start () {
		ballSpawn();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw ("Horizontal") > 0 && gameObject.transform.position.x < rightBound){
			gameObject.transform.Translate(paddleSpeed, 0, 0);
		}
		if(Input.GetAxisRaw ("Horizontal") < 0 && gameObject.transform.position.x > leftBound){
			gameObject.transform.Translate(-paddleSpeed, 0, 0);
		}

		if(prelaunchBall) {
			ballBod = prelaunchBall.rigidbody;
			ballBod.position = transform.position + new Vector3(0,1,0);
			if(Input.GetButtonDown ("Jump")){
				ballBod.isKinematic = false;
				ballBod.AddForce (0,ballSpeed,0);
				prelaunchBall = null;
			}
		}
	}

	//Instantiates a copy of the prefab, stored in the paddle
	void ballSpawn() {
		prelaunchBall = Instantiate(ballPrefab, (transform.position + new Vector3(0,5,0)), Quaternion.identity) as GameObject;
	}

	void OnCollisionEnter(Collision colson){
		audio.PlayOneShot(paddleSound,0.5f);
		foreach(ContactPoint cp in colson.contacts){
			if(cp.thisCollider == collider){
				float reboundAngle = cp.point.x - transform.position.x;
				cp.otherCollider.rigidbody.AddForce(200*reboundAngle,0,0);
			}
		}
	}
}

