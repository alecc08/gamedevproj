using UnityEngine;
using System.Collections;

public class nextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "MainCharacter")
        {
            PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, GameConstants.FINAL_SCENE);
            Application.LoadLevel(GameConstants.LOADING);
        }
    }
}
