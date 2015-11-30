using UnityEngine;
using System.Collections;

public class FinalSceneScript : MonoBehaviour {

    AudioSource lightningSound;

    GameObject mainChar;

	// Use this for initialization
	void Start () {
        lightningSound = GameObject.Find("ElectricSound").GetComponentInChildren<AudioSource>();
        mainChar = GameObject.Find("MainCharacter");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
