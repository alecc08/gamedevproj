using UnityEngine;
using System.Collections;

public class LoadingSceneScript : MonoBehaviour
{

    AsyncOperation async;

    float timeSinceLoad = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLoad += Time.deltaTime;
        if(timeSinceLoad > 7.0f && async == null)
        {
            async = Application.LoadLevelAsync(PlayerPrefs.GetString(GameConstants.GET_SCENE_TO_LOAD));
        }
        
    }
    
}
