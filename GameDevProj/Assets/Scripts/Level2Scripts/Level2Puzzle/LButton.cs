using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class LButton : MonoBehaviour, Interactable {

	MainPuzzle puzzle;
	string idL;
	
	bool check;
	float timer;
	
	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idL = "3";
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
		return idL;
	}
	
	public void interact(GameObject player)
	{
		timer = 0f;
		puzzle.setAnswer (idL);
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
		return "Press L";
	}
	
}