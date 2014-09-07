using UnityEngine;
using System.Collections;

public class core : MonoBehaviour {
	public GameObject blockPrefab;
	public static int score = 0;
	public static int lives = 3;

	// Use this for initialization
	void Start () {
		blockMaker();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.color = Color.yellow;
		GUI.Label(new Rect(25,10,100,50), "Score: " + score);
		GUI.Label(new Rect(700,10,100,50), "Lives: " + lives);
	}

	void blockMaker()
	{
		for(int i = -5; i < 6; i++)
		{
			Instantiate(blockPrefab,new Vector3(i*5,10,0),Quaternion.identity);
		}
	}
}
