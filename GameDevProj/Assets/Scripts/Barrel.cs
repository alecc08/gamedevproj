using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Barrel : MonoBehaviour, Interactable {

    Rigidbody barrelBody;

	// Use this for initialization
	void Start () {
        barrelBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void interact()
    {
        Debug.Log("Applying force to barrel!");
        barrelBody.AddForce(new Vector3(0, 200f, 0));
    }
}
