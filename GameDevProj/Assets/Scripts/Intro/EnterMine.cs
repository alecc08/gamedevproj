using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class EnterMine : MonoBehaviour, Interactable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void interact(GameObject player)
	{
		//PlayerPrefs.SetString(GameConstants.GET_SCENE_TO_LOAD, GameConstants.TUTORIAL);
		//Application.LoadLevel(GameConstants.LOADING);
	}
	
	public bool isInteractable()
	{
		return true;
	}
	
	public string getLabel()
	{
		return "Enter Abandoned Mine";
	}



}
