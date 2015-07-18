using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int score = 0;

	// Use this for initialization
	void Start () {
	
		GUI.Label (new Rect (20, 20, 100, 30), "Score " + (score));

	}
	
	// Update is called once per frame
	void Update () {
	

	}

}
