using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float spawnTime = 1.0f;
	public float scale = 2.5f;
	public int counter = 0;
	// Update is called once per frame
	public void Update () {
	
		counter++;

		if (counter == 33){

			counter = 0;

			GameObject asteroid = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			asteroid.AddComponent<Asteroid>();
			asteroid.transform.localScale = new Vector3(scale,scale,scale);

			float minRandom;
			float maxRandom;

			if (MovementPlayer.finalPos > 0){
				minRandom = -1.0f;
				maxRandom = 1.49f;
			}
			else if (MovementPlayer.finalPos < 0){
				minRandom = -1.49f;
				maxRandom = 1.0f;
			}
			else{
				minRandom = -1.0f;
				maxRandom = 1.0f;
			}

			int randomPos = Mathf.RoundToInt(Random.Range(minRandom,maxRandom));
			randomPos = randomPos * 3;
			asteroid.transform.position = new Vector3(randomPos, transform.position.y);

			if (Random.Range(0,2) > 0){

				GameObject secAsteroid = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				secAsteroid.AddComponent<Asteroid>();
				secAsteroid.transform.localScale = new Vector3(scale,scale,scale);
				if (randomPos > 0){
					int secRandomPos = Random.Range (-1,1);
					secRandomPos = secRandomPos * 3;
					secAsteroid.transform.position = new Vector3(secRandomPos, transform.position.y);
				}
				else if (randomPos < 0){
					int secRandomPos = Random.Range (0,2);
					secRandomPos = secRandomPos * 3;
					secAsteroid.transform.position = new Vector3(secRandomPos, transform.position.y);
				}
				else{
					int secRandomPos = Random.Range (-1,2);
					while (secRandomPos == 0) secRandomPos = Random.Range (-1,2);
					secRandomPos = secRandomPos * 3;
					secAsteroid.transform.position = new Vector3(secRandomPos, transform.position.y);
				}

			}

		}

	}

}
