using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class SampleReadable : MonoBehaviour, Readable  {

	public string GetText()
    {
        return "Do not stray from\nthe light for\ntoo long or suffer the\nconsequences...";
    }
}
