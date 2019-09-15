using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour {
	
	public GameObject pref;
	public int noobjects;
	private Vector3 position;
	// Use this for initialization
	public void GetInput(string number){

		noobjects = int.Parse (number);
		if (noobjects != 0) {
			SpawnBalls ();
		}
	}
	void SpawnBalls () {
		for(int i= 0;i<noobjects;i++){
			//spawn number of objects at random position according to the user input 
			position = new Vector3 (Random.Range (-5, 5), Random.Range (-5, 5), Random.Range (-5, 5));
			//actually creartes the object
			Instantiate (pref, position, Quaternion.identity);

		
	}
	}

}
