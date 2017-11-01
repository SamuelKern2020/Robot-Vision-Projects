using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonBallCtrl : MonoBehaviour {

	//public vars
    public float deathTime = 5.0f;
    public Text gameMessage;
    

//    public CameraCtrl cameraController;

    
	//private vars
    private float timeAlive;	//the running time the ball has been alive
    

	//public or private??
	void OnCollisionEnter(Collision col){

		Debug.Log ("Collision registered!");


		if (col.gameObject.tag == "targetCollision") {
			//register a hit
			Debug.Log ("Target hit!");
//            cameraController.TargetHit();
//            camera.GetComponent<CameraCtrl>().TargetHit();
//            cameraController.TargetHit();
            
            //Other way:
            Time.timeScale = 0.0f;  //freezes game
            gameMessage.text = "You win!";
            
            
		}


		//call the timer coroutine
		StartCoroutine (DeathCounter () );	


	}

	IEnumerator DeathCounter() {
		yield return new WaitForSeconds(deathTime);
		Destroy(this.gameObject);
	}



	// Use this for initialization
	void Awake () {
//		cameraController = GameObject.Find("MainCamera").GetComponent<CameraCtrl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
