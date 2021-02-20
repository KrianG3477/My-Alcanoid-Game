using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScorerEvent : MonoBehaviour
{
    [SerializeField]
    private string objectTag;
    [SerializeField]
    private UnityEvent scorerEvent;

    ScoreManager scoreManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            scorerEvent.Invoke();
        }
    }
}
