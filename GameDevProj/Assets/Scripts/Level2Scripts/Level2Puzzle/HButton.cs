using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class HButton : MonoBehaviour, Interactable {


	MainPuzzle puzzle;
	string idH;

	bool check;
	float timer;
	
	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idH = "1";
		timer = 0f;
		check = true;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (check == false) {
			if(timer > 3f)
				check = true;	
		}
	}

	public string getID()
	{
		return idH;
	}
	
	public void interact(GameObject player)
	{
		timer = 0f;
		puzzle.setAnswer (idH);
		check = false;
	}
	
	public bool isInteractable()
	{
		if(check == true)
			return true;
		return false;
	}
	
	public string getLabel()
	{
		return "Press H";
	}
	
}