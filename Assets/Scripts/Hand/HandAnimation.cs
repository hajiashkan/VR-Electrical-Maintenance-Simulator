using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;


public class HandAnimation : MonoBehaviour
{
    [SerializeField] Animator handAnimator;
    private const string GRAB = "Grab";
    private const string POINT = "Point";
    public void OnGrab(bool State)
    {
        handAnimator.SetBool(GRAB, State);
    }
    public void OnPint(bool State)
    {
        handAnimator.SetBool(POINT, State);
    }
}
