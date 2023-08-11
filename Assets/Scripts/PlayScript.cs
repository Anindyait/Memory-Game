
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayScript : MonoBehaviour
{
    GameObject fade, audioControl, optionBG;
    Vector3 optionBGScale = new Vector3(0,0,0);
    void Start()
    {
       fade = GameObject.Find("Fade");
       audioControl = GameObject.Find("AudioControl");
        optionBG = GameObject.Find("OptionBG");
        optionBGScale = optionBG.transform.localScale;
        optionBG.transform.localScale = new Vector3(0,0,0);
    }



    public void CrossPickGrid()
    {
        audioControl.GetComponent<AudioControl>().ButtonClick();

        optionBG.transform.localScale = new Vector3(0,0,0);

    }
    public void FourByFour()
    {
        GameController.size = 8;
        audioControl.GetComponent<AudioControl>().ButtonClick();
        fade.GetComponent<Fade>().FadeEffect();
        //Wait();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

        public void SixBySix()
    {
        GameController.size = 18;
        audioControl.GetComponent<AudioControl>().ButtonClick();
        fade.GetComponent<Fade>().FadeEffect();
        //Wait();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayOptions()
    {
        audioControl.GetComponent<AudioControl>().ButtonClick();
        optionBG.transform.localScale = optionBGScale;
    } 

    public void QuitGame()
    {
        audioControl.GetComponent<AudioControl>().ButtonClick();

        Application.Quit();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        
    }
}
