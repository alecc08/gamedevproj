using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class RoomGate : MonoBehaviour, Interactable {

	[SerializeField]
	GameObject roomLight;

	AudioSource creepyKid;
	GameObject roomGate;
	GameObject cabinetDoorL, cabinetDoorR;
	bool openCabinetDoor;

	float timer;

	// Use this for initialization
	void Start () {
		timer = 0f;
		openCabinetDoor = false;
		creepyKid = GetComponent<AudioSource>();
		roomGate = GameObject.FindGameObjectWithTag ("roomGate");
		cabinetDoorL = GameObject.FindGameObjectWithTag ("cabinetDoor");
		cabinetDoorR = GameObject.FindGameObjectWithTag ("cabinetDoor2");
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (openCabinetDoor == true) {
		
			if(timer < 5f){
				cabinetDoorL.transform.position += new Vector3(0.2f,0,0)* Time.deltaTime;		
				cabinetDoorR.transform.position += new Vector3(-0.07f,0,0) * Time.deltaTime;
			}
			



		}
	}
	
	public void interact(GameObject player)
	{
		Destroy (roomLight);
		roomGate.transform.position = new Vector3 (99.789f, -.022f, 85.293f);
		openCabinetDoor = true;
		creepyKid.Play ();
		timer = 0f;
	}
	
	public bool isInteractable()
	{
		return true;
	}
	
	public string getLabel()
	{
		return "Examine Poster";
	}
}

