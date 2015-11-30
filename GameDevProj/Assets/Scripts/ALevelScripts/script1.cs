using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class script1 : MonoBehaviour, Readable {

    public string GetText()
    {
        return "You didn't want to\ngo this way anyway...";
    }
}
