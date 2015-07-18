using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	float vel = 0.02f;

	// Update is called once per frame
	void Update () {
	
		if (transform.position.y < -4){
			Score.score++;
			Destroy(gameObject);
		}

		transform.position = new Vector3(transform.position.x, transform.position.y - vel);

		vel += 0.02f;

	}
}
