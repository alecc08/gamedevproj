using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Alex_key_script : MonoBehaviour, Interactable {

    GameObject Alexdoor;

	// Use this for initialization
	void Start () {
        Alexdoor = GameObject.Find("AlexDoor");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void interact(GameObject player)
    {

        Alexdoor.GetComponent<Alex_door_script>().locked = false;

        Destroy(this.gameObject);
        //Play key noise
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
