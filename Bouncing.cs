using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    [SerializeField]
    private Transform trans;
    [SerializeField]
    private Rigidbody2D getRigidbody;
    [SerializeField]
    private float speedUpRate = 0.05f;
    // �̵� ����
    private Vector2 direction = Vector3.zero;
    // �Ի簢 ����
    private Vector2 incomingVector;
    // ���� ����
    private Vector2 normalVector;

    // Move, Reflect ������Ʈ ��������
    [SerializeField]
    private Move move = null;
    [SerializeField]
    private Reflect reflect = null;
    [SerializeField]
    private Delete delete = null;

    private void Start()
    {
        StartDirec();
    }


    // Update is called once per frame
    void Update()
    {
        move.Go(direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �Ի簢
        incomingVector = direction;
        // �ݻ�
        direction = reflect.Invoke(incomingVector, collision);

        // �ݶ��̴� �±װ� ����̸� ����Ʈ n�ۼ�Ʈ ����
        if (collision.gameObject.tag == "Block")
        {
            delete.Invoke(collision);
            move.Speed += move.Speed * speedUpRate;
        }


    }

    

    // ó�� ���� ���� ����
    private void StartDirec()
    {
        Vector2 direc = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction = direc.normalized;
    }
}
