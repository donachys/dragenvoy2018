using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class convoylist1 : MonoBehaviour {
	public GameObject[] vehAry;
	private static List<GameObject> vehicles;
	//public GameObject car;
	public GameObject leader;
	private static LeadVehicleMovement leadermovement;
	// Use this for initialization
	void Start () {
		leadermovement = leader.GetComponent<LeadVehicleMovement>();
		vehicles = new List<GameObject>();
		for(int i = 0; i < vehAry.Length; i++){
			vehicles.Add (vehAry[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void increaseLength(){
		leadermovement.ForwardForce += 0.6f;
		leadermovement.RotationSpeed += 7;
		applyDiminishingDrag ();
		List<GameObject> templist = convoylist1.getVehicles();
		int size = convoylist1.getVehicles().Count;
		Vector2 pos = templist[size-1].transform.position-templist[size-1].transform.up;
		Quaternion rot = templist[size-1].transform.rotation;
		//pos = pos-new Vector3(0,-1,0);
		GameObject tempobj = Instantiate(Resources.Load("prefabs/bodySection"), pos, rot) as GameObject;//Instantiate(Resources.Load("PrefabName"), position, rotation)
		tempobj.tag = "body";
		HingeJoint2D hj = templist[size-1].AddComponent<HingeJoint2D>() as HingeJoint2D;
		hj.anchor = new Vector2(0,-1);
		hj.useLimits = true;
		JointAngleLimits2D lims = hj.limits;
		lims.min = -45;
		lims.max = 45;
		hj.limits = lims;
		templist[size-1].GetComponent<HingeJoint2D>().connectedBody = tempobj.GetComponent<Rigidbody2D>();
		//tempobj.transform.localScale = new Vector3(1,1,1);
		//OTAnimatingSprite otscript = tempobj.GetComponent<OTAnimatingSprite>();
		//otscript.size.X = 1;
		//otscript.size.Y = 1;
		convoylist1.getVehicles().Add(tempobj);
	}
	public static List<GameObject> getVehicles(){
		return vehicles;	
	}
	public static void applyDiminishingDrag(){
		List<GameObject> templist = convoylist1.getVehicles();
		for (int i = templist.Count-1; i >=0; i--){
			if ((templist.Count - i) <= 5) {
				Rigidbody2D temprb2D = templist [i].GetComponent<Rigidbody2D> () as Rigidbody2D;
				temprb2D.drag = Mathf.Clamp (temprb2D.drag - 0.25f, 0.01f, 5.0f);
			} else {
				Rigidbody2D temprb2D = templist [i].GetComponent<Rigidbody2D> () as Rigidbody2D;
				temprb2D.drag = 0.01f;
			}
		}
	}
	public static void applyIncreasingDrag(){
		List<GameObject> templist = convoylist1.getVehicles();
		for (int i = 0; i < templist.Count; i++){
			Rigidbody2D temprb2D = templist [i].GetComponent<Rigidbody2D>() as Rigidbody2D;
			temprb2D.drag = Mathf.Clamp (temprb2D.drag + 0.125f, 0.0f, 2.0f);
		}
	}
}
