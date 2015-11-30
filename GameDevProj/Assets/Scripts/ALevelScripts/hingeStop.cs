using UnityEngine;
using System.Collections;

public class hingeStop : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "GrateHingeStop")
        {
            hingeScript hinge = GameObject.Find("GrateHinge").GetComponent<hingeScript>();
            hinge.activated = false;
        }
    }
}
