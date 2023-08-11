using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessScreen : MonoBehaviour
{
        GameObject audioControl;
    // Start is called before the first frame update
    void Start()
    {
        audioControl = GameObject.Find("AudioControl");
        audioControl.GetComponent<AudioControl>().SuccessSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
