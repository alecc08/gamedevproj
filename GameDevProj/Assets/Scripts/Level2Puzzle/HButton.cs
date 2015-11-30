using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class HButton : MonoBehaviour, Interactable {


	MainPuzzle puzzle;
	string idH;
	
	// Use this for initialization
	void Start () {
		puzzle = GetComponentInParent<MainPuzzle> ();
		idH = "1";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string getID()
	{
		return idH;
	}
	
	public void interact(GameObject player)
	{
		puzzle.setAnswer (idH);
	}
	
	public bool isInteractable()
	{
		return true;
	}
	
	public string getLabel()
	{
		return "Press H";
	}
	
}