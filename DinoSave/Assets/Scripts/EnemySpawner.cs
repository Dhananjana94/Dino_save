using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;

	public float xPositionLimit; // deside range of enemy generate

	public float SpawnRate;

	// Use this for initialization
	void Start () {

		//SpawnSpike ();
		StartSpawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnSpike(){
		
		float randomX = Random.Range (-xPositionLimit, xPositionLimit); // limits of enemy position

		Vector2 SpawnPosition = new Vector2 (randomX, transform.position.y); // Only x position should be random but y position should be same

		Instantiate (enemy,SpawnPosition,Quaternion.identity); //what is the position enemy should spike
	}

	public void StartSpawn(){
	
		InvokeRepeating ("SpawnSpike",1f,SpawnRate); // repeat SpawnSpike function 1 sec to 1 sec 
	} 

	public void StopSpawn(){
	
		CancelInvoke ("SpawnSpike");
	}

}
