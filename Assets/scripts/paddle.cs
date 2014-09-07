using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	public float paddleSpeed;
	// Use this for initialization
	void Start () {
		paddleSpeed = .5f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw ("Horizontal") > 0 && gameObject.transform.position.x < 25){
			gameObject.transform.Translate(0, 0, paddleSpeed);
		}
		if(Input.GetAxisRaw ("Horizontal") < 0 && gameObject.transform.position.x > -25){
			gameObject.transform.Translate(0, 0, -paddleSpeed);
		}
	}
}
