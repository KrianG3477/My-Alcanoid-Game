using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHeartEvents : MonoBehaviour
{
    private int heart = 3;

    [SerializeField]
    private UnityEvent noHeartEvent;

    public int Heart { get => heart; set => heart = value; }

    [SerializeField]
    private GameObject hp1Heart;
    [SerializeField]
    private GameObject hp2Heart;
    [SerializeField]
    private GameObject hp3Heart;


    void Update()
    {
        if (heart <= 0f)
        {
            noHeartEvent.Invoke();
        }
    }
}
