using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLife : MonoBehaviour
{
    [SerializeField]
    private int lifePoint = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            lifePoint -= 1;

            if (lifePoint <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
