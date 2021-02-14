using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    // �̵��ӵ�
    private float speed = 7f;
    // �̵� ����
    private Vector3 direction = Vector3.zero;

    //������� direction�� ���� ���ϵ��� ���� ������Ƽ. �������ͷ� ��ȯ�ϵ�����.
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