using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class testbutton : MonoBehaviour {
	public GameObject car;
	public GameObject leader;
	private LeadVehicleMovement leadermovement;
	public GameObject spawnArea;
	private SpawnLocations spawns;
	public int numberToSpawnAtStart = 10;
	// Use this for initialization
	void Start () {
		leadermovement = leader.GetComponent<LeadVehicleMovement>();
		spawns = spawnArea.GetComponent<SpawnLocations>();
		
		for(int i = 0; i<numberToSpawnAtStart; i++){
			Vector3 pos = spawns.getSpawnLocation();
			Quaternion rot = transform.rotation;//new Quaternion(0f,0f,0f,0f);
			GameObject tempobj = Instantiate(Resources.Load("prefabs/pickup"), pos, rot) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void spawnPickup(){
		
	}
	//void OnGUI(){
		//if (GUI.Button(new Rect(Screen.width-150, Screen.height-100, 150, 100), new GUIContent("click)", "Click to continue."))){
			//convoylist1.increaseLength();
			//Vector3 pos = spawns.getSpawnLocation();
			//Quaternion rot = transform.rotation;//new Quaternion(0f,0f,0f,0f);
			//GameObject tempobj = Instantiate(Resources.Load("prefabs/pickup"), pos, rot) as GameObject;
			//instantiate here
			/*leadermovement.ForwardForce += 0.6f;
			leadermovement.RotationSpeed += 7;
			List<GameObject> templist = convoylist1.getVehicles();
			int size = convoylist1.getVehicles().Count;
			Vector3 pos = templist[size-1].transform.position-templist[size-1].transform.up;
			Quaternion rot = templist[size-1].transform.rotation;
			//pos = pos-new Vector3(0,-1,0);
			GameObject tempobj = Instantiate(car, pos, rot) as GameObject;
			tempobj.tag = "body";
			HingeJoint hj = templist[size-1].AddComponent("HingeJoint") as HingeJoint;
			hj.anchor = new Vector3(0,-1,0);
			hj.axis = new Vector3(0,0,1);
			hj.useLimits = true;
			JointLimits lims = hj.limits;
			lims.min = -45;
			lims.max = 45;
			hj.limits = lims;
			templist[size-1].hingeJoint.connectedBody = tempobj.rigidbody;
			//tempobj.transform.localScale = new Vector3(1,1,1);
			//OTAnimatingSprite otscript = tempobj.GetComponent<OTAnimatingSprite>();
			//otscript.size.X = 1;
			//otscript.size.Y = 1;
			convoylist1.getVehicles().Add(tempobj);*/
		//}
	//}
}
