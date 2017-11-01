using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float timeLeft = 30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        Debug.Log (timeLeft);
        
        if(timeLeft < 0){
            GameOver();
        }
		
	}
    
    void GameOver (){
        Debug.Log ("GAME OVER");
    }
}
