using UnityEngine;
using System.Collections;

public class ScoreInfo : MonoBehaviour {
	public int infoWidth = 200;
	public int infoHeight = 100;
	public static int Score = 0;
	public static int HighScore = 0;
	GUIStyle style;
	public Texture2D texture;
	//public TextAsset imageTextAsset;
	
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		//texture = new Texture2D(infoWidth, infoHeight);
		
		//Texture2D tex = new Texture2D(4, 4);
        //tex.LoadImage(imageTextAsset.bytes);
		//texture.LoadImage(imageTextAsset.bytes);
        //renderer.material.mainTexture = tex;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		/*for (int y = 0; y < texture.height; ++y){
			for (int x = 0; x < texture.width; ++x){
				//float r = Random.value;
				//238-221-130
				Color color = new Color(238, 221, 130);
				texture.SetPixel(x, y, color);
			}
		}
		texture.Apply();
		 */
		style.normal.background = texture;
		//GUI.Box(new Rect(100, 100, 100, 100), new GUIContent(""), style);
		//Debug.Log ("gui warehouse");
		Camera c = Camera.main; //GameObject.FindGameObjectWithTag("MainCamera") as Camera;
		Vector3 pos = c.WorldToViewportPoint(transform.position);
		//GUI.Box(new Rect(c.WorldToViewportPoint(transform.position),c.WorldToViewportPoint(transform.position)), "text");
		GUI.Box(new Rect(pos.x*Screen.width-(infoWidth/2), Screen.height-pos.y*Screen.height-(infoHeight/2), infoWidth, infoHeight),new GUIContent( "Score:\t" + Score + "\n Highest:\t" + HighScore), style);
		//GUI.Box(new Rect(pos.x*Screen.width-(infoWidth/2), Screen.height-pos.y*Screen.height-(infoHeight/2), infoWidth, infoHeight),new GUIContent( "Score: " + Score.ToString(), texture));
		//Debug.Log (c.WorldToViewportPoint(transform.position));
	}
}
