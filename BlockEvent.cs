using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlockEvent : MonoBehaviour
{
    [SerializeField]
    private UnityEvent noChildEvent;

    void Update()
    {
        if (this.transform.childCount <= 0f)
        {
            noChildEvent.Invoke();
            Destroy(gameObject);
        }
    }
}
