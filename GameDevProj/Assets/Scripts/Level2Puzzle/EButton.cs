using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class EButton : MonoBehaviour, Interactable {

	MainPuzzle puzzle;
	string idE;

	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idE = "2";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string getID()
	{
		return idE;
	}
	
	public void interact(GameObject player)
	{
		puzzle.setAnswer (idE);
	}
	
	public bool isInteractable()
	{
		return true;
	}
	
	public string getLabel()
	{
		return "Press E";
	}
	
}