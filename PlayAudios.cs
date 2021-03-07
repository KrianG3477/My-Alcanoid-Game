using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudios : MonoBehaviour
{
    [SerializeField]
    private AudioClip hitPlayerBarSound;
    [SerializeField]
    private AudioClip hitWallSound;
    [SerializeField]
    private AudioClip hitBlockSound;
    [SerializeField]
    private AudioSource audioSource;

    private string tagName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlaySound(collision.gameObject.tag);
    }

    public void PlaySound(string tagName)
    {
        switch (tagName)
        {
            case "Player":
                audioSource.clip = hitPlayerBarSound;
                break;

            case "Wall":
                audioSource.clip = hitWallSound;
                break;

            case "Block":
                audioSource.clip = hitBlockSound;
                break;
        }
        audioSource.Play();
    }
}
