using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class LButton : MonoBehaviour, Interactable {

	MainPuzzle puzzle;
	string idL;

	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idL = "3";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string getID()
	{
		return idL;
	}
	
	public void interact(GameObject player)
	{
		puzzle.setAnswer (idL);
	}
	
	public bool isInteractable()
	{
		return true;
	}
	
	public string getLabel()
	{
		return "Press L";
	}
	
}