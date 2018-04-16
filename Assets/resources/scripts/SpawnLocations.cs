using UnityEngine;
using System.Collections;

public class SpawnLocations : MonoBehaviour {
	public GameObject[] TopLefts;
	public GameObject[] BotRights;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public Vector3 getSpawnLocation(){
		int num1 = (int)Random.Range(0, TopLefts.Length);
		float x = Random.Range (TopLefts[num1].transform.position.x,BotRights[num1].transform.position.x);
		float y = Random.Range (TopLefts[num1].transform.position.y,BotRights[num1].transform.position.y);
	//	Debug.Log("num1 was: " + num1);
		
		return new UnityEngine.Vector3(x,y,0f);
	}
}
