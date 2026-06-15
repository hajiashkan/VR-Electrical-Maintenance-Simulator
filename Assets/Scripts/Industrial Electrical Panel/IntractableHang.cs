using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntractableHang : MonoBehaviour
{
    [SerializeField] private Transform hangPlace;
    private bool isFollowing;
    public void OnFollowing()
    {
        isFollowing = true;
    }
    public void OnReleaseHang()
    {
        isFollowing = false;
    }

    void Update()
    {
        if (!isFollowing)
        {
            transform.position = hangPlace.position;
            transform.rotation = hangPlace.rotation;

          //  isFollowing = true;
        }
    }
}
