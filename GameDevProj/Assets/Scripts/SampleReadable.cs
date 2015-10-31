using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class SampleReadable : MonoBehaviour, Readable  {

	public string GetText()
    {
        return "Sample text\nMake sure you\nadd new lines\nwhere necessary";
    }
}
