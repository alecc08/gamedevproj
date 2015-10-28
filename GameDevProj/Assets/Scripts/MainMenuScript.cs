using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.anyKey)
        {
            PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, GameConstants.MAIN_MENU_LEVEL);
            Application.LoadLevel(GameConstants.LOADING);
        }
	}
}
