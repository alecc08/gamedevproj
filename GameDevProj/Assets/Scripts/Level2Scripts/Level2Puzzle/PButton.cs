using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class PButton : MonoBehaviour, Interactable {

	MainPuzzle puzzle;
	string idP;

	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idP = "4";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string getID()
	{
		return idP;
	}

	public void interact(GameObject player)
	{
		puzzle.setAnswer (idP);
	}
	
	public bool isInteractable()
	{
		return true;
	}
	
	public string getLabel()
	{
		return "Press P";
	}

}
