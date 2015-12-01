using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class PButton : MonoBehaviour, Interactable {

	MainPuzzle puzzle;
	string idP;

	bool check;
	float timer;
	
	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idP = "4";
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
		return idP;
	}
	
	public void interact(GameObject player)
	{
		timer = 0f;
		puzzle.setAnswer (idP);
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
		return "Press P";
	}

}
