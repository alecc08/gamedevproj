using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;

public class MainCharacterScript : MonoBehaviour {

    Light spotLight;
    GameObject faceUiLarge; //Used for notes or hints
    GameObject faceUiSmall; //Used for "Press E to interact" text

    Text smallUiText;
    Text largeUiText;

    GameObject currentReadable = null;

    bool buttonOneDown = false;
    bool buttonOneWasDown = false;
    bool buttonTwoDown = false;
    bool buttonTwoWasDown = false;
    bool buttonThreeDown = false;
    bool buttonThreeWasDown = false;
    bool buttonFourDown = false;
    bool buttonFourWasDown = false;

    const string SMALL_UI_TEXT = "(X) ";

    bool faceUiSmallActive = false;
    bool faceUiLargeActive = false;

	// Use this for initialization
	void Start () {
        spotLight = GetComponentInChildren<Light>();
        faceUiLarge = GameObject.Find("FaceUILarge");
        largeUiText = faceUiLarge.GetComponentInChildren<Text>();
        faceUiLarge.SetActive(false);
        
        faceUiSmall = GameObject.Find("FaceUISmall");
        smallUiText = faceUiSmall.GetComponentInChildren<Text>();
        faceUiSmall.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        UpdateGamepadButtons();
        faceUiSmallActive = false;
        faceUiLargeActive = false;
        if (Input.GetKeyUp(KeyCode.F) || buttonFourClicked())
        {
            spotLight.enabled = !spotLight.enabled;
        }
        

        
        //Cast some rays to see if you're pointing at any creatures
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 10f))
        {
            if(hit.collider.gameObject != null)
            {
                GameObject hitObject = hit.collider.gameObject;
                if(hit.distance < 2.0f && hitObject.tag.Equals("item"))
                {
                    smallUiText.text = SMALL_UI_TEXT + hitObject.name;
                    faceUiSmallActive = true;
                    if ((Input.GetKeyUp(KeyCode.X) || buttonThreeClicked()) && hitObject.GetComponent<Interactable>() != null)
                    {
                        hitObject.GetComponent<Interactable>().interact();
                    }

                }
                else if (hit.distance < 1.5f && hitObject.tag.Equals("readable"))
                {
                    if(currentReadable == null || !currentReadable.Equals(hitObject))
                    {
                        currentReadable = hitObject;
                        largeUiText.text = hitObject.GetComponent<Readable>().GetText();
                    }
                    faceUiLargeActive = true;

                }
                else if(hitObject.name.StartsWith("ghoul") && spotLight.enabled)
                {
                    GhoulAI ghoul = hitObject.GetComponent<GhoulAI>();
                    ghoul.disappear();
                }

            }
        }
            
        faceUiSmall.SetActive(faceUiSmallActive);
        faceUiLarge.SetActive(faceUiLargeActive);
        
	}

    private void UpdateGamepadButtons()
    {
        buttonOneWasDown = buttonOneDown;
        buttonTwoWasDown = buttonTwoDown;
        buttonThreeWasDown = buttonThreeDown;
        buttonFourWasDown = buttonFourDown;

        buttonOneDown = OVRInput.Get(OVRInput.Button.One);
        buttonTwoDown = OVRInput.Get(OVRInput.Button.Two);
        buttonThreeDown = OVRInput.Get(OVRInput.Button.Three);
        buttonFourDown = OVRInput.Get(OVRInput.Button.Four);
    }

    private bool buttonOneClicked() //A button
    {
        return buttonOneDown && !buttonOneWasDown;
    }
    private bool buttonTwoClicked() //B
    {
        return buttonTwoDown && !buttonTwoWasDown;
    }
    private bool buttonThreeClicked()//X
    {
        return buttonThreeDown && !buttonThreeWasDown;
    }
    private bool buttonFourClicked()//Y
    {
        return buttonFourDown && !buttonFourWasDown;
    }
}
