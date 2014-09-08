using UnityEngine;
using System.Collections;

public class core : MonoBehaviour {
	public GameObject blockPrefab;
	public static int score = 0;
	public static int lives = 3;
	public Camera maincam;
	public Camera firstperson;

	// Use this for initialization
	void Start () {
		maincam.enabled = true;
		firstperson.enabled = false;
		blockMaker();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.G)){
			if(maincam.enabled){
				firstperson.enabled = true;
				maincam.enabled = false;
			}
			else{
				firstperson.enabled = false;
				maincam.enabled = true;
			}
		}
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
