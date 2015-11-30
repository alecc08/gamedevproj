using UnityEngine;
using System.Collections;

public class Sarah : MonoBehaviour {

	// Reference to audio sources
	AudioSource pant; 

	bool check;

	// Use this for initialization
	void Start () {
		pant = GetComponent<AudioSource> ();
		check = true;
	}
	
	// Update is called once per frame
	void Update () {
        

	
	}

	void OnTriggerEnter(Collider col){
		if (check == true) {
			pant.Play();
			check = false;
		
		}


	}


}
