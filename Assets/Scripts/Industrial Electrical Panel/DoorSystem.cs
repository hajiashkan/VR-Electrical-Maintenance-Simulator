using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    [SerializeField] private Transform hangTransform;
    void Update()
    {
        FollowTheHang(hangTransform);
    }
    private void FollowTheHang(Transform hang)
    {
        Vector3 FilteredTarget = hang.position;
        FilteredTarget.y = transform.position.y;
        transform.LookAt(FilteredTarget);
    }
}
