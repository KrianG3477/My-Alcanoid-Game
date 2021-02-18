using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBallEvent : MonoBehaviour
{
    [SerializeField]
    GameObject ballSpownButton;
    [SerializeField]
    PlayerHeart PlayerHeart;
    [SerializeField]
    private string tagName = "Ball";


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tagName)
        {
        ballSpownButton.SetActive(true);
        PlayerHeart.Heart -= 1;
        }
    }
}