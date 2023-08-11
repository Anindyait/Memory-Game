
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windowed : MonoBehaviour
{
    // Start is called before the first frame update
    public void FullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        if(isFullScreen)
            Debug.Log("FullScreen");
        else
            Debug.Log("Windowed");

    }
}
