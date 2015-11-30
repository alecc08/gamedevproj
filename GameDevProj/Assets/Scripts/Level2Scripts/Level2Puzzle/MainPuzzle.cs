using UnityEngine;
using System.Collections;

public class MainPuzzle : MonoBehaviour {

	string answer;
	string code;

	// Use this for initialization
	void Start () {
		answer = "";
		code = "1234";
	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log (answer);
		if (answer.Length > 4) {
			answer = "";
		}
		else if(answer.Equals(code)){
			PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, "ALevel");
			Application.LoadLevel(GameConstants.LOADING);
		}


	}

	public void setAnswer(string x){
		answer += x;
	
	}
}






