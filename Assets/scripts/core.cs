using UnityEngine;
using System.Collections;

public class core : MonoBehaviour {
	public GameObject blockPrefab;

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
			Instantiate(blockPrefab,new Vector3(i*5,10,0),Quaternion.identity);
		}
	}
}
