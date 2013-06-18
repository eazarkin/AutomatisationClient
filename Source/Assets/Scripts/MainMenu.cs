using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public GUIStyle style = new GUIStyle();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		int LeftMenuWidth = 25; //ширина в процентах от ширины экрана 
		int LeftMenuHight = 75; //высота  в процентах от высоты экрана считая от левого верхнего края
		int BottomMenuHight = 15; //высота  в процентах от высоты экрана 		
	   	
		
		GUI.Box(new Rect(0,0,Screen.width*LeftMenuWidth/100+Screen.width/50, Screen.height*LeftMenuHight/100+Screen.height/100),""); 	
		GUILayout.BeginArea(new Rect(Screen.width/100, Screen.height/100, Screen.width*LeftMenuWidth/100, Screen.height*LeftMenuHight/100));
		GUILayout.MinHeight(Screen.height/10);
		GUILayout.Button("Домой");
        GUILayout.Button("1 Этаж");
		GUILayout.Button("2 Этаж");
        GUILayout.Button("Общий вид");			
        GUILayout.EndArea();
		
		
		//if (GUI.Button (new Rect (10,10,150,100), "I am a button")) {
		//	print ("You clicked the button!");
		//}
		//if (GUI.Button (new Rect (10,10,150,100), "I am a button")) {
	//		print ("You clicked the button!");
	//	}
	//	if (GUI.Button (new Rect (10,10,150,100), "I am a button")) {
	//		print ("You clicked the button!");
	//	}
	//	if (GUI.Button (new Rect (10,10,150,100), "I am a button")) {
	//		print ("You clicked the button!");
	//	}
	//	if (GUI.Button (new Rect (10,10,150,100), "I am a button")) {
	//		print ("You clicked the button!");
	//	}
	}
}
