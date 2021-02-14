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
    // 이동 방향
    private Vector2 direction = Vector3.zero;
    // 입사각 변수
    private Vector2 incomingVector;
    // 법선 변수
    private Vector2 normalVector;

    // Move, Reflect 컴포넌트 가져오기
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
        // 입사각
        incomingVector = direction;
        // 반사
        direction = reflect.Invoke(incomingVector, collision);

        // 콜라이더 태그가 블록이면 스피트 n퍼센트 증가
        if (collision.gameObject.tag == "Block")
        {
            delete.Invoke(collision);
            move.Speed += move.Speed * speedUpRate;
        }


    }

    

    // 처음 시작 방향 설정
    private void StartDirec()
    {
        Vector2 direc = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction = direc.normalized;
    }
}
