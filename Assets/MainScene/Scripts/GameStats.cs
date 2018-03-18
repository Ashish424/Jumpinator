using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStats : MonoBehaviour{



	public Player player;
	public Text scoreText;
	public Text highScore;
	public GameObject platformHolder;
	public int platChildren;
	
	
	
	void Awake(){
		holderTransform = platformHolder.GetComponent<Transform>();
	}

	// Use this for initialization
	void Start (){

		Coroutine c = StartCoroutine(scoreUpdater());
		highScore.text = "HighScore "+PlayerPrefs.GetInt("HighScore");
		

	}

	IEnumerator scoreUpdater(){
		int i = 0;
		scoreText.text = "Score " + i;

	
		while (player.alive()){
			
			yield return new WaitForSeconds(1.0f);
			scoreText.text = "Score " + i;
			if (!player.alive()){
				break;
			}
			++i;
		}
		
		PlayerPrefs.SetInt("HighScore",Math.Max(i,PlayerPrefs.GetInt("HighScore")));
		SceneManager.LoadScene("MainScene",LoadSceneMode.Single);

		
	}
	// Update is called once per frame
	void Update () {
		platChildren = holderTransform.childCount;


		if (Input.GetKeyDown(KeyCode.Escape)){
			//TODO cleanup here
			Application.Quit();
		}
		
		
		
		
	}
	
	private Transform holderTransform;

}
