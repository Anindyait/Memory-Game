using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pairs : MonoBehaviour
{
    TMP_Text pairsCount;
    int noOfPairs;
    GameObject gameController;
    public Animator anim;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        pairsCount = GetComponent<TMP_Text>();
        gameController = GameObject.Find("GameController");
        noOfPairs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        pairsCount.text = GameController.pairsFound.ToString() + "/" + GameController.size.ToString();
        if(noOfPairs < GameController.pairsFound)
        {
            anim.SetBool("rotate", true);
            //TimeDelay();
        }
        
        noOfPairs = GameController.pairsFound;
    }

    public void SetRotationFalse()
    {
        anim.SetBool("rotate", false);
    }
    
        IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("rotate", false);

        

    }
}
