using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBallEvent : MonoBehaviour
{
    [SerializeField]
    GameObject ballSpownButton;
    [SerializeField]
    PlayerHeartEvents PlayerHeart;
    [SerializeField]
    private string tagName = "Ball";

    [SerializeField]
    private AudioClip hitBallSound;
    [SerializeField]
    private AudioSource audioSource;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tagName)
        {
            audioSource.clip = hitBallSound;
            audioSource.Play();

            PlayerHeart.Heart -= 1;
            
            if (PlayerHeart.Heart > 0)
                ballSpownButton.SetActive(true);
        }
    }
}
