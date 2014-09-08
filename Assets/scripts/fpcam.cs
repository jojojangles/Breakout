using UnityEngine;
using System.Collections;

public class fpcam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 padloc = GameObject.FindGameObjectWithTag("paddle").transform.position;
		Vector3 camloc = transform.position;
		transform.position = new Vector3(padloc.x,-33,-6);
	}
}
