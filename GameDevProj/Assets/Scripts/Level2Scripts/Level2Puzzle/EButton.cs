using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class EButton : MonoBehaviour, Interactable {

	MainPuzzle puzzle;
	string idE;

	bool check;
	float timer;
	
	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idE = "2";
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
		return idE;
	}
	
	public void interact(GameObject player)
	{
		timer = 0f;
		puzzle.setAnswer (idE);
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
		return "Press E";
	}
	
}