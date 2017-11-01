using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetCtrl : MonoBehaviour {

	public Text gameMessage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){



		if (col.gameObject.tag == "cannonBallCol") {
			//register a hit
			Debug.Log ("Target hit!");

			//Other way:
//			Time.timeScale = 0.0f;  //freezes game
			gameMessage.text = "You win!";


		}
			


	}
}
