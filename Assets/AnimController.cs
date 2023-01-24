using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public GameObject thePlayer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("8Key") || Input.GetButtonDown("1Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Idle");
            Debug.Log("Input Idle");
        }
        if (Input.GetButtonDown("9Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Melee360");
            Debug.Log("Input Melee360");
        }
        if (Input.GetButtonDown("2Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Standing Dive Forward");
            Debug.Log("Input Dodge");
        }
        if (Input.GetButtonDown("4Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Hit To Body");
            Debug.Log("Input HitToBody");
        }
        if (Input.GetButtonDown("5Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Falling Idle");
            Debug.Log("Input FallingLoop");
        }
        if (Input.GetButtonDown("7Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Rifle Punch");
            Debug.Log("Input Special2");
        }
        if (Input.GetButtonDown("5Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Punching");
            Debug.Log("Input Normal");
        }
        if (Input.GetButtonDown("6Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Punch Combo");
            Debug.Log("Input Special");
        }
        if (Input.GetButtonDown("3Key"))
        {
            thePlayer.GetComponent<Animator>().Play("Getting Up");
            Debug.Log("Input GettingUp");
        }
    }
}
