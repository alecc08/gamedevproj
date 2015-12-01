using UnityEngine;
using System.Collections;

public class MainPuzzle : MonoBehaviour {

	AudioSource wrongAns;

	string answer;
	string code;

	// Use this for initialization
	void Start () {
		answer = "";
		code = "1234";
		wrongAns = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log (answer);
		if (answer.Equals (code)) {
			PlayerPrefs.SetString (GameConstants.GET_SCENE_TO_LOAD, "ALevel");
			Application.LoadLevel (GameConstants.LOADING);
		} else if (answer.Length >= 4) {
			answer = "";
			wrongAns.Play ();
		} 
			


	}

	public void setAnswer(string x){
		answer += x;
	
	}
}






