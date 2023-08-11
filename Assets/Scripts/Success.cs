using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Success : MonoBehaviour
{
    public int noOfFlips;
    GameObject success, gameController;
    // Start is called before the first frame update
    void Start()
    {
        GameController.pairsFound = 0;
        gameController = GameObject.Find("GameController");
        success = GameObject.Find("Success");
                //success.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameController.pairsFound == GameController.size)
        {
            
            noOfFlips = CardFlip.count;
            StartCoroutine(TimeDelay(0.1f));
        }
    }

        IEnumerator TimeDelay(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }
}
