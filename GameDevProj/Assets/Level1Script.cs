using UnityEngine;
using System.Collections;

public class Level1Script : MonoBehaviour {

    MainCharacterScript mainChar;

	// Use this for initialization
	void Start () {
        SanitySystem.Reset();
        mainChar = GameObject.Find("MainCharacter").GetComponentInChildren<MainCharacterScript>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
