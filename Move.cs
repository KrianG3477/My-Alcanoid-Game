using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    // 이동속도
    private float speed = 7f;
    // 이동 방향
    private Vector3 direction = Vector3.zero;

    //멤버변수 direction을 쓰기 편하도록 만든 프로퍼티. 단위벡터로 반환하도록함.
    public Vector3 Direction
    {
        get
        {
            return direction.normalized;
        }
        set
        {
            direction = value;
        }
    }

    public float Speed { get => speed; set => speed = value; }

    // Update is called once per frame
    void Update()
    {
        Go(Direction);
    }

    public void Go(Vector3 direction)
    {
        transform.position += direction * speed * Time.smoothDeltaTime;
    }
}