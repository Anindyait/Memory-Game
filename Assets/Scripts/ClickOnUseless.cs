using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnUseless : MonoBehaviour
{
    GameObject menu;

    void Start() {
        menu = GameObject.Find("MenuBG");
    }

    public void OnMouseDown()
    {
        menu.GetComponent<Menu>().UnPause();   
    }

}