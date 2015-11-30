using UnityEngine;
using System.Collections;

public abstract class HintScript : MonoBehaviour
{
    bool hasBeenRead = false;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("MainCharacter"))
        {
            if (!hasBeenRead)
            {
                hasBeenRead = true;
                other.gameObject.GetComponent<MainCharacterScript>().setHint(getHint());
            }
            
        }
    }

    protected abstract string getHint();
}
