using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		if(GUI.Button( new Rect(340, 415, 125, 100), "Yes"))
		{
			print ("holy dicks!");
			Application.LoadLevel("yepyep");
		}
		if(GUI.Button ( new Rect(700, 415, 125, 100), "No"))
		{
			print ("Jesus with tits");
			Application.Quit();
		}
	}
}
