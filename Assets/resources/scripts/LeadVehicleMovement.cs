using UnityEngine;
using System.Collections;

public class LeadVehicleMovement : MonoBehaviour {
	public float ForwardForce = 10;
	public float RotationSpeed = 10;
	private float x;
	private bool paused = false;

	private Rigidbody2D rb2D;
	private Vector2 velocity;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		velocity = new Vector2 (0, 10);
	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetButtonUp("p")){
			if(!paused){
				Time.timeScale = 0;	
				paused = true;
			}else{
				Time.timeScale = 1;
				paused = false;
			}
			Debug.Log ("P Pressed");	
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		GameObject go = other.gameObject;
		if(go.CompareTag("body")){
			if(ScoreInfo.Score > ScoreInfo.HighScore){
				ScoreInfo.HighScore = ScoreInfo.Score;	
			}
			ScoreInfo.Score = 0;
			Application.LoadLevel (Application.loadedLevel);	
		}
	}
	void FixedUpdate () {
		//rigidbody.AddRelativeForce(Vector3.up*ForwardForce*Time.deltaTime*10);//,ForceMode.Impulse
		//Debug.Log ("setting velocity" + rigidbody.velocity);
//		Debug.Log("av: " + GetComponent<Rigidbody2D>().angularVelocity);
		//Debug.Log ("v3x: " + Vector3.right*x*Time.deltaTime);
//		rigidbody.AddRelativeTorque(-Vector3.forward*x*RotationSpeed*20);

		GetComponent<Rigidbody2D>().velocity = (transform.up*ForwardForce);//,ForceMode.Impulse
//		GetComponent<Rigidbody2D>().angularVelocity = (-Input.GetAxis("Horizontal") * RotationSpeed);

//		rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
		rb2D.MoveRotation(rb2D.rotation + (-Input.GetAxis("Horizontal") * RotationSpeed) * Time.fixedDeltaTime);

	}
}
