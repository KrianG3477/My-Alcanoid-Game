using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangeloop : MonoBehaviour
{
    [SerializeField]
    private float range = 8f;
    [SerializeField]
    private Transform trans;
    private float halfRange;


    private void Start()
    {
        halfRange = range / 2;
    }
    void Update()
    {
        if(trans.position.x > halfRange || trans.position.x < -halfRange )
        {
            Teleport();
        }
    }

    private void Teleport()
    {
        trans.position = new Vector3(trans.position.x * -0.9f , trans.position.y, trans.position.z);
    }
}
