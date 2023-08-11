using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlipNo : MonoBehaviour
{
    TMP_Text FlipCount;
    // Start is called before the first frame update
    void Start()
    {
        FlipCount = GetComponent<TMP_Text>();
        FlipCount.text = "with " + CardFlip.count.ToString() + " flips";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
