﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Player player;
    //PlayerController2 player;
    Vector3 offset;
    void Start()
    {
        //player = FindObjectOfType<PlayerController2>();
        player = FindObjectOfType<Player>();
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
