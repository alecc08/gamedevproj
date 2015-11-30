using UnityEngine;
using System.Collections;

public class RoarScript : MonoBehaviour {

	// Reference to audio sources
	public AudioSource mRoar;
	bool check;

	// Use this for initialization
	void Start () {
		check = true;
	}


	
	void OnTriggerEnter(Collider col){
		if (check == true) {
			mRoar.Play ();
		} 
	}

}
