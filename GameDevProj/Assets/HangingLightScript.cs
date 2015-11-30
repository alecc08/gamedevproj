using UnityEngine;
using System.Collections;

public class HangingLightScript : MonoBehaviour {

    Quaternion fromRot;
    Quaternion toRot;

    bool goingFrom = true;

	// Use this for initialization
	void Start () {
        fromRot = new Quaternion(transform.rotation.x + 10f, transform.rotation.y, transform.rotation.z, 1.0f);
        toRot = new Quaternion(transform.rotation.x - 10f, transform.rotation.y, transform.rotation.z, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if(goingFrom)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, fromRot, Time.deltaTime*0.3f);
            if(transform.rotation.x == fromRot.x)
            {
                goingFrom = false;
            }

        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, toRot, Time.deltaTime * 0.3f);
            if (transform.rotation.x == toRot.x)
            {
                goingFrom = true;
            }
        }
        
	}
}
