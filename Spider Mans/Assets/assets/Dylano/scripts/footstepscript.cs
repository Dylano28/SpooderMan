﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepscript : MonoBehaviour
{
    public GameObject footstep;
    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            {
                footstep.SetActive(true);
            }
        }
        if (Input.GetKeyUp("w")) 
        {
            StopFootsteps();
        }


    }
    void footsteps()
    {
        footstep.SetActive(true);
    }
    void StopFootsteps()
    {
        footstep.SetActive(false);
    }
}
