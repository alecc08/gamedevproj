using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class BoneHinge : MonoBehaviour, Interactable {


    bool interacted;

    GameObject hinge;
    
    // Use this for initialization
	void Start () {
        interacted = false;
        hinge = GameObject.Find("BoneHinge");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void interact(GameObject player)
    {
        if (!interacted)
        {
            interacted = true;
            hinge.transform.Rotate(Vector3.right, -60f);

            hingeScript grateHinge = GameObject.Find("GrateHinge").GetComponent<hingeScript>();
            grateHinge.activated = true;
        }
    }

    public string getLabel()
    {
        if (!interacted)
            return "Activate";
        else
            return "";

    }

    public bool isInteractable()
    {
        return !interacted;
    }
}
