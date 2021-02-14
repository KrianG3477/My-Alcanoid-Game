using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public void Invoke(Collision2D collision) 
    {
        Destroy(collision.gameObject);
    }
}
