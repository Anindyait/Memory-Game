using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFlip : MonoBehaviour
{
    GameObject Card;
    public static SpriteRenderer previousCard, presentCard = null, fstCard = null;
    public static int count = 0;
    public Sprite[] front;
    public Sprite back; 
    public SpriteRenderer spriteRenderer;
    GameObject hoverCard, gameController, audioControl, pairs;
    bool isMouseHover, allowed=true;
    public int frontIndex;
    Vector3 ogSize;

    bool updateFlag = false;
    
    static int c = 0;
    public void OnMouseDown() 
    {

        pairs.GetComponent<pairs>().SetRotationFalse();
        if(allowed)
        {
            if(gameController.GetComponent<GameController>().match[frontIndex] == false)
            {
                if(spriteRenderer.sprite == back)
                {
                    //spriteRenderer.color = Color.green;
                    if(!gameController.GetComponent<GameController>().TwoCardsUp())
                    {
                    
                        count++;
                        spriteRenderer.sprite = front[frontIndex];
                        if(gameController.GetComponent<GameController>().firstCard == null)
                            gameController.GetComponent<GameController>().firstCard = spriteRenderer;
                        else
                            gameController.GetComponent<GameController>().secondCard = spriteRenderer;
                        gameController.GetComponent<GameController>().AddFrontFace(frontIndex);
                        gameController.GetComponent<GameController>().match[frontIndex] = gameController.GetComponent<GameController>().IsMatch();
                        
                        if(gameController.GetComponent<GameController>().match[frontIndex])
                        {
                            Debug.Log("Success!");
                        }
                        gameController.GetComponent<GameController>().twoCardsUp = gameController.GetComponent<GameController>().TwoCardsUp();
                        if(!gameController.GetComponent<GameController>().TwoCardsUp())
                        {
                            fstCard = spriteRenderer;
                        }
                        else
                            presentCard = spriteRenderer;

                    }
   
                }
                else
                {
                    spriteRenderer.sprite = back;
                    gameController.GetComponent<GameController>().RemoveFrontFace(frontIndex);
                }
            }
        }

    }
    IEnumerator FlipBack()
    {
        yield return new WaitForSeconds(1);
        c++;
        if(spriteRenderer == fstCard)
        {
            spriteRenderer.sprite = back;
            fstCard = null;
        }
        if(spriteRenderer == presentCard)
        {
            spriteRenderer.sprite = back;
            presentCard = null;
        }
        gameController.GetComponent<GameController>().RemoveAllFrontFace();
        allowed = true;
        
    }



    // Start is called before the first frame update
    void Start()
    {
        pairs = GameObject.Find("PAirs");
        gameController = GameObject.Find("GameController");
        spriteRenderer = GetComponent<SpriteRenderer>();
        Card = GameObject.Find("Card");
        isMouseHover = false;
        hoverCard = GetComponent<SpriteRenderer>().gameObject;
        count = 0;
        ogSize = hoverCard.transform.localScale;
        audioControl = GameObject.Find("AudioControl");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameController.GetComponent<GameController>().match[frontIndex] && !updateFlag) 
        {
            updateFlag = true;
            spriteRenderer.color = Color.white;
        }
        
       
        if(gameController.GetComponent<GameController>().TwoCardsUp() && allowed)
        {
            if(!gameController.GetComponent<GameController>().IsMatch())
            {
                allowed = false;
                audioControl.GetComponent<AudioControl>().WrongSound();

                StartCoroutine(FlipBack());
            }

        }


    }
        IEnumerator TimeDelay(int delayTime)
    {
        yield return new WaitForSeconds(2);
        spriteRenderer.sprite = back;

    }




    private void OnMouseOver()
    {
        if(!isMouseHover)
        {
            //Debug.Log("Hover");
            Hover();
        }
        isMouseHover = true;
       
    }

    void OnMouseExit()
    {
        if(isMouseHover)
            Hover_nt();
        isMouseHover = false;
    }

    void Hover()
    {
        if(!gameController.GetComponent<GameController>().match[frontIndex]) 
        { 
            hoverCard.transform.localScale += new Vector3(9f,9f,0);
            audioControl.GetComponent<AudioControl>().HoverSound();
            spriteRenderer.color = Color.green;
        }
        else
            spriteRenderer.color = Color.red;

        
    }
     void Hover_nt()
    {  
        if(!gameController.GetComponent<GameController>().match[frontIndex]) 
        {
            spriteRenderer.color = Color.white;
        }
        hoverCard.transform.localScale = ogSize;
        updateFlag = false;
    }
}

