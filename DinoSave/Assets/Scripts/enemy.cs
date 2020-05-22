using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour {

	public GameObject dust;

	private void OnTriggerEnter2D(Collider2D collision){
	
		if(collision.gameObject.tag == "Player"){

			Destroy (collision.gameObject); // when enemy crash with the dino dino will distroy

			GameManager.instance.GameOver(); // call GameOver function inside in the GameManager
		}

		else if(collision.gameObject.tag == "ground"){

			GameManager.instance.IncrementScore (); // when enemy touch the ground score will be increse

			gameObject.SetActive (false);
			GameObject dustEffect = Instantiate (dust,transform.position,Quaternion.identity); // when enemy crash with ground dust will generate

			Destroy (dustEffect,2f); // after 2 seconds dustEffect will destroy
			Destroy (gameObject,3f); //when enemy collide with ground enemy will distroy 
		}
	}
}
