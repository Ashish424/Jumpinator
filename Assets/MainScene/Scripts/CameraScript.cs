using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour{


	public Transform player;
	public float getCamLength(){
//		Debug.Log("the cam length is "+2*myCam.orthographicSize * myCam.aspect);
		return 2*myCam.orthographicSize * myCam.aspect;
	}

	public float getRightBound(){
		return transform.position.x+getCamLength()/2;
	}

	public float getlowerBound(){

		return transform.position.y - myCam.orthographicSize;
	}

	
	private void Awake(){
		myCam = GetComponent<Camera>();

	}




	private void Start(){
		
		offsetX =  transform.position.x - player.position.x;
	
	}
	
	private void LateUpdate(){
		transform.position = new Vector3(player.position.x+offsetX,transform.position.y,transform.position.z);

	}

	private Camera myCam;
	private float offsetX;


}
