using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class count : MonoBehaviour
{
    TMP_Text ClickCount;
    // Start is called before the first frame update
    void Start()
    {
        
        ClickCount = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int noOfClicks = CardFlip.count;
        ClickCount.text = noOfClicks.ToString();
    }
}
