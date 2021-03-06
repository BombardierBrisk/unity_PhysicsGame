﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public float cameraDistOffset = 10;
    private Camera mainCamera;
    private GameObject player;
    public float CameraHeight;
    public float CameraForward;
    // Use this for initialization
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInfo = player.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x + CameraForward, playerInfo.y + CameraHeight, playerInfo.z);
    }
}