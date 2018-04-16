using UnityEngine;
using System.Collections;

public class SpaceCapture : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Application.LoadLevel(1);	
		}
	}
}
