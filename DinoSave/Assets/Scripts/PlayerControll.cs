using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {


	Rigidbody2D rb;

	float xInput;

	Vector2 newPosition; // Object has position with x and y direction

	public float MoveSpeed;
	public float xPositionLimit;


	//public float xPositionLimit; // mesure the limit of dino movement

	public Animator animator;

	private void Awake(){

		rb = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate(){

		MovePlayer();
	}	

	void MovePlayer(){

	//when press arrow key values change between -1 to +1
		xInput = Input.GetAxis("Horizontal"); 
		newPosition = transform.position; // get object's current position

		//newPosition.x = newPosition.x + xInput;
		newPosition.x += xInput * MoveSpeed;

		animator.SetFloat ("speed", Mathf.Abs(newPosition.x));

		newPosition.x = Mathf.Clamp (newPosition.x, -xPositionLimit, xPositionLimit);

		rb.MovePosition(newPosition);



		//.......................................................................................................




		//Dino will change it's head direction when press arrow keys
		Vector3 characterScale = transform.localScale;

		if(Input.GetAxis("Horizontal") < 0){

			characterScale.x = -0.3f;
			
		}

		if(Input.GetAxis("Horizontal") > 0){

			characterScale.x = 0.3f;

		}

		transform.localScale = characterScale;

	}
}
