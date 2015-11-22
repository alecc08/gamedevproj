using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class AltarNote : MonoBehaviour, Readable {

	public string GetText()
    {
        return "You must remember your\n past before you may\ngo farther";
    }
}
