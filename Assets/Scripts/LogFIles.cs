using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class LogFIles : MonoBehaviour {
	private string myfilepath;
	public GameObject pref;
	private string temp;

	// Use this for initialization
	void Start () {
		//specify a path for logging
		myfilepath = "Enter_Your_Path" + "/" + "movements_avatar.txt";
		//Example:myfilepath = "F:/Unity/Connected_Robotics" + "/" + "movements_avatar.txt"

		
	}
	void Update(){
		//transform 3D vector coordinates to string to save
		temp = transform.position.ToString ("G4");

		WriteToFile (temp);
	
	}
	
	public void WriteToFile(string message){
		// Make A filewriter object and specify path
		StreamWriter fileWriter = new StreamWriter (myfilepath,true);
		//Write to a File
		fileWriter.WriteLine (message);
		//Close the file so other prefabs can access it
		fileWriter.Close ();
	
	}
}
