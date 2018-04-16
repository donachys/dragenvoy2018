using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	public GameObject objectToFollow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = objectToFollow.transform.position.x;
		float y = objectToFollow.transform.position.y;
		transform.position = new Vector3(x,y,-1000f);//objectToFollow.transform.position;
		
	}
}
