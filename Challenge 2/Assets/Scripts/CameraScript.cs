﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public AudioSource musicSource;
    public AudioSource musicSource2;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public int score;


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        musicSource.clip = musicClipOne;
        musicSource.Play();
        musicSource2.clip = musicClipTwo;


    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
        score = PlayerScript.scoreValue;
       
        if (score == 8)
        {
            if (musicSource.mute == false)
            {
                musicSource.mute = true;
                musicSource2.Play();
            }
        }

    }            
}
    



