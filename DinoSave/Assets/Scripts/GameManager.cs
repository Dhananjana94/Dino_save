using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance; // using this we can access all the property from any other scripts
	bool gameOver = false;
	int score = 0;
	public Text ScoreText;
	public Text ScorePannel;
	public GameObject gameOverPannel;

	private void Awake(){
	
		if(instance == null){

			instance = this;
		}

	}

	public void GameOver(){
	
		gameOver = true;

		GameObject.Find ("EnemySpawn").GetComponent<EnemySpawner>().StopSpawn(); // we access EnemySpawner class inside EnemySpawn and stopSpown public funtion
	
		ScorePannel.text = "Score : " + score;
		gameOverPannel.SetActive (true); // if game over pannel will display
	}

	public void IncrementScore(){

		if(!gameOver){

			score++;
			//print (score);

			ScoreText.text = score.ToString (); // score will display on screen
		}


	}

	public void MainMenu(){
	
		SceneManager.LoadScene ("Menu");
	
	}

	public void Restart(){
	
		SceneManager.LoadScene ("Game");
	
	}
}
