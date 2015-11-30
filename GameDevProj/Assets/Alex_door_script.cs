using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Alex_door_script : MonoBehaviour, Interactable{

    public bool locked = true;
    private bool open = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public string getLabel()
    {
        if (locked)
        {
            return "Locked. (Need key)";
        }
        else
        {
            return "To open door";
        }
    }

    public void interact(GameObject player)
    {
        if (locked == false)
        {
            gameObject.GetComponent<Animation>().Play("DoorOpen");
            open = true;
        }
        //Play key noise
    }

    public bool isInteractable()
    {
        if (!open) return true;
        else return false;
    }
}
