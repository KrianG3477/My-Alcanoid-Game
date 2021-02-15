using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect : MonoBehaviour
{
    // 입사각 변수
    private Vector2 incomingVector;
    // 법선 변수
    private Vector2 normalVector;
    private Vector2 barNomalVector;
    [SerializeField]
    private GameObject exGameObject;

    // direction 반사각으로 변경
    public Vector2 Invoke(Vector2 incomingV, Collision2D collision)
    {
        // 충돌 면의 법선
        normalVector = collision.contacts[0].normal;


        Vector2 normalV = Vector2.zero;
        Vector2 direction = Vector2.zero;

        if (collision.gameObject == exGameObject)
        {
            Vector2 positionVecter = gameObject.transform.position - collision.transform.position ;
            direction = positionVecter.normalized;
        }
        else
        {
            normalV = normalVector;

            Vector2 reflectVector = Vector2.Reflect(incomingV, normalV);
            direction = reflectVector.normalized;
        }
        return direction;
    }
}
