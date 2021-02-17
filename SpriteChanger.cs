using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Sprite spriteA;
    [SerializeField]
    private Sprite spriteB;
    [SerializeField]
    private Sprite spriteC;

    private bool isSwitch = true;

    [SerializeField]
    private float waitSeconds = 0.5f;
    [SerializeField]
    PlayerHeart playerHeart;

    [SerializeField]
    private int survivHp = 1;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        StartCoroutine("SpriteChange");
    }

    private IEnumerator SpriteChange()
    {
        while (true)
        {
            // 생존수치가 플레이어 하트랑 같을시 C스프라이트로 바꾸고 시간이 지나면 비활성화
            if (playerHeart.Heart == survivHp)
            {
                spriteRenderer.sprite = spriteC;
                yield return new WaitForSeconds(waitSeconds);
                gameObject.SetActive(false);
            }
            else if (isSwitch)
            // 평소엔 스프라이트 A,B를 시간마다 바꾼다
            {
                spriteRenderer.sprite = spriteA;
                isSwitch = !(isSwitch);
                yield return new WaitForSeconds(waitSeconds);
            }
            else
            {
                spriteRenderer.sprite = spriteB;
                isSwitch = !(isSwitch);
                yield return new WaitForSeconds(waitSeconds);
            }
        }
    }
}
