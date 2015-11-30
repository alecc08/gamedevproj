using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class PickupBone : MonoBehaviour, Interactable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void interact(GameObject player)
    {
        PlaceBone socket = GameObject.Find("SwitchSocket").GetComponent<PlaceBone>();

        socket.hasBone = true;

        Destroy(gameObject);
    }

    public string getLabel()
    {
        return "Pick up";
    }

    public bool isInteractable()
    {
        return true;
    }
}
