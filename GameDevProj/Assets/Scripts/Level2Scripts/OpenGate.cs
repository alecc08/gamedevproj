using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class OpenGate : MonoBehaviour, Interactable {

	AudioSource gateOpen;
	GameObject gate;
	bool open;
	float timer;

	// Use this for initialization
	void Start () {
		timer = 0f;
		open = false;
		gate = GameObject.FindGameObjectWithTag ("gate");
		gateOpen = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (open == true) {
			if(gate != null){
				gate.transform.position += new Vector3 (0, 5f, 0) * Time.deltaTime;
				if (timer > 5f)
					Destroy (GameObject.FindGameObjectWithTag ("gate"));
			}
		}
	}

	public void interact(GameObject player)
	{
		timer = 0f;
		open = true;
		gateOpen.Play ();
	}

	public bool isInteractable()
	{
		return true;
	}

	public string getLabel()
	{
		if (gate == null) {
			return "";
		}
		else
			return "Pull Knife Out";
	}
}
