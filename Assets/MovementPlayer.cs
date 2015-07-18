using UnityEngine;
using System.Collections;

public class MovementPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// local inicial do objeto
		atualPos = transform.position.x;

	}

	// moveLeft e moveRight servem para descobrir se esta se movendo
	// twicePress pra saber se sao duas para esquerda ou direita
	// vel a velocidade do movimento
	// finalPos a posicao onde o jogador deve chegar
	// atualPos e a posicao atual
	// velCount para saber qual a velocidade deve estar

	public bool moveLeft = false;
	public bool moveRight = false;
	public bool twicePress = false;
	public float vel = 0.1f;
	public static float finalPos;
	public float atualPos;
	public int velCount;

	// Update is called once per frame
	void Update () {

		KeyPress();
		Move();

	}

	void KeyPress(){
	
		if (Input.GetKeyDown(KeyCode.A) && moveLeft){

			twicePress = true;
			finalPos = -3.0f;

		}
		else if (Input.GetKeyDown(KeyCode.A)){

			moveLeft = true;
			moveRight = false;
			twicePress = false;
			if (atualPos > 0.0f) finalPos = 0.0f;
			else finalPos = -3.0f;

		}
		else if (Input.GetKeyDown(KeyCode.D) && moveRight){

			twicePress = true;
			finalPos = 3.0f;

		}
		else if (Input.GetKeyDown(KeyCode.D)){

			moveLeft = false;
			moveRight = true;
			twicePress = false;
			if (atualPos < 0.0f) finalPos = 0.0f;
			else finalPos = 3.0f;

		}
	
	}

	void Move(){
		
		if (moveLeft){
			
			if (transform.position.x <= finalPos + 0.2f){

				transform.position = new Vector3(finalPos, transform.position.y);
				moveLeft = false;
				vel = 0.1f;
				velCount = 0;
				atualPos = finalPos;
				
			}
			else{
				
				atualPos -= vel;
				transform.position = new Vector3(atualPos, transform.position.y);
				transform.Rotate(-180f/17f, 0f, 0f);
				velCount++;
				if (velCount > 7) vel = 0.2f;
				if (velCount > 12)  vel = 0.3f;
				
			}
			
		}
		else if (moveRight){
			
			if (transform.position.x >= finalPos - 0.2f){

				transform.position = new Vector3(finalPos, transform.position.y);
				moveRight = false;
				vel = 0.1f;
				velCount = 0;
				atualPos = finalPos;
				
			}
			else{
				
				atualPos += vel;
				transform.position = new Vector3(atualPos, transform.position.y);
				transform.Rotate(180f/17f, 0f, 0f);
				velCount++;
				if (velCount > 7) vel = 0.2f;
				if (velCount > 12)  vel = 0.3f;
				
			}
			
		}
		
	}

}
