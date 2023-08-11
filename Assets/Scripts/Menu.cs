using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    GameObject menu, cardContainer, optionBG, audioControl;
    Vector3 scale = new Vector3(0,0,0), scaleMenu = new Vector3(0,0,0);
    bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("MenuBG");
        cardContainer = GameObject.Find("CardContainer");
        scaleMenu = menu.transform.localScale;
        menu.transform.localScale = new Vector3(0,0,0);
        isPaused = false;
        optionBG = GameObject.Find("OptionBG");
        audioControl = GameObject.Find("AudioControl");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false)
            {
                Pause();
            }
            else
            {
                UnPause();        
            }
        }
    }

    public void Pause()
    {
        menu.transform.localScale = scaleMenu;
        scale = cardContainer.transform.localScale;
        cardContainer.transform.localScale = new Vector3(0,0,0);
        audioControl.GetComponent<AudioControl>().ButtonClick();
        isPaused = true;
    }

    public void UnPause()
    {
        menu.transform.localScale = new Vector3(0,0,0);
        cardContainer.transform.localScale = scale;
        optionBG.transform.localScale = new Vector3(0,0,0);
        audioControl.GetComponent<AudioControl>().ButtonClick();

        isPaused = false;   
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
