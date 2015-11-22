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

    public void interact(GameObject player)
    {
        Debug.Log("Applying force to barrel!");
        Vector3 force = this.transform.position - player.transform.position;
        barrelBody.AddForce(force.normalized * 200);
    }
}
