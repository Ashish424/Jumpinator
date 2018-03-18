using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	
	
	
	// Use this for initialization
	void Start () {
		
	}


	public void onPressStart(){
		
		SceneManager.LoadScene("MainScene");
	}

	public void onPressedQuit(){
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDestroy(){
		Debug.Log("main menu destroyed ");
	}
}
