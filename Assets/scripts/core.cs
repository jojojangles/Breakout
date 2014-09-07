using UnityEngine;
using System.Collections;

public class core : MonoBehaviour {
	public GameObject block;

	// Use this for initialization
	void Start () {
		blockMaker();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void blockMaker()
	{
		for(int i = -5; i < 6; i++)
		{
			Instantiate(block,new Vector3(i*5,10,0),Quaternion.identity);
		}
	}
}
