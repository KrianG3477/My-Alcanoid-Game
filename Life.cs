using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private int lifePoint = 1;


    [SerializeField]
    private string objectTag;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == objectTag)
        {
            lifePoint -= 1;

            if (lifePoint <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
