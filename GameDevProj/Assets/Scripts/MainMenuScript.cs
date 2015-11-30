using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(OVRInput.Get(OVRInput.Button.Start) || Input.GetKeyUp(KeyCode.Return))
        {
            PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, "Forest(Intro)");
            Application.LoadLevel(GameConstants.LOADING);
        }
	}
}
