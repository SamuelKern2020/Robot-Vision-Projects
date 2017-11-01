using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraCtrl : MonoBehaviour {
    
    public GameObject cannonBall;
	public float speed = 10;
    public float cannonballSpeed = 5000f;
    public float timeLeft = 5.0f;
    
    public Text timerText;
    public Text gameMessage;
    
    private bool targetHit = false;
	private Rigidbody rb;
    

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        updateTimer();
        gameMessage.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

        // Using FORCES / PHYSICS
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

		rb.AddForce (movement * speed);
	}
    
    void Update(){
        
        timeLeft -= Time.deltaTime;    
        if(timeLeft < 0){
            GameOver();
        }
        else{
            updateTimer(); 
        }
    }
    
    void GameOver (){
        Debug.Log ("GAME OVER");
        gameMessage.text = "TIME'S UP! You LOOSE!";
    }
    
    void updateTimer () {
        timerText.text = "Time Remaining: " + timeLeft.ToString("0");
    }
    
    public void TargetHit(){
        gameMessage.text = "You Win!";
    }
    
    
     
    // Require the rocket to be a rigidbody.
    // This way we the user can not assign a prefab without rigidbody
    
    public void FireRocket () {
		Debug.Log ("FireRocket called!");
		GameObject newCannonBall = Instantiate(cannonBall, transform.position, transform.rotation) as GameObject;

        Rigidbody rb2 = newCannonBall.GetComponent<Rigidbody>();	//creates a variable that acesses the component's rigidBody (gives access to force mainuplation)

		Vector3 movement = new Vector3 (0.0f, 0.0f, 1.0f);
//        Vector3 movement = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

		rb2.AddForce (movement * cannonballSpeed);

//         You can also acccess other components / scripts of the clone
//        rocketClone.GetComponent<MyRocketScript>().DoSomething();
    }
    
//    public void FireCannon()
//    {
//        GameObject boom = Instantiate (projectile) as GameObject;
//        boom.transform.position = Camera.main.transform.position;
//        Rigidbody rb = boom.GetComponent<Rigidbody>();
//        
//    }
}
