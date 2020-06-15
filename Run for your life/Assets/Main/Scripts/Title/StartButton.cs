﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public Animator fade;

    private Collider myCollider; 
    private Rigidbody myRigidbody;
    private int count1;
    private int count2;
    private AudioSource source;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        // source.Pause();
        count1=0;
        count2=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) 
    {
        
        if (other.CompareTag("Right Hand")) 
        {
            Debug.Log("HEY");
            source.Play();
            count1+=1;
            if((count1>=1)&&(count2>=1)){
                SceneManager.LoadScene("FastIKSample");
            }
            
        }if (other.CompareTag("Left Hand")) 
        {
            Debug.Log("HEY");
            source.Play();
            count2+=1;
            if((count1>=1)&&(count2>=1)){
                fade.SetTrigger("Start");
                StartCoroutine(LevelLoader.LoadLevel(0));
            }
            
        }
        
        
        
    }
}
