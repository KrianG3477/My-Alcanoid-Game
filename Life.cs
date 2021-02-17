using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private int lifePoint = 1;

    private GameObject GameObject;

    [SerializeField]
    private string objectName;

    private void Start()
    {
        GameObject = GameObject.Find(objectName);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == GameObject)
        {
            lifePoint -= 1;

            if (lifePoint <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
