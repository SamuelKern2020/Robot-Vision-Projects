using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCtrl : MonoBehaviour {
    
    public GameObject cannonBall;
	public float speed;
    public float cannonballSpeed = 10f;
	private Rigidbody rb;
    

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
//		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

		rb.AddForce (movement * speed);
	}
    
    void Update(){
            
       
    }
     
    // Require the rocket to be a rigidbody.
    // This way we the user can not assign a prefab without rigidbody
    
    public void FireRocket () {
		Debug.Log ("FireRocket called!");
		GameObject newCannonBall = Instantiate(cannonBall, transform.position, transform.rotation) as GameObject;

        Rigidbody rb2 = newCannonBall.GetComponent<Rigidbody>();	//creates a variable that acesses the component's rigidBody (gives access to force mainuplation)

		Vector3 movement = new Vector3 (0.0f, 0.2f, 1.0f);
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
