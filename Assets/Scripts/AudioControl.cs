using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hoverSound, wrongSound, rightSound, buttonClick, success, gameStart;
    [SerializeField] float volume = 0.5f;
    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverSound, 0.1f);
    }

    public void WrongSound()
    {
        audioSource.PlayOneShot(wrongSound, 0.02f);
    }

    public void RightSound()
    {
        audioSource.PlayOneShot(rightSound, 0.5f);
    }

    public void ButtonClick()
    {
        audioSource.PlayOneShot(buttonClick, 0.3f);
    }
    public void SuccessSound()
    {
        audioSource.PlayOneShot(success, 0.5f);
    }

        public void GameStart()
    {
        audioSource.PlayOneShot(gameStart, 0.2f);
    }
}
