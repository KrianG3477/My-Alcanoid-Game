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
            // ������ġ�� �÷��̾� ��Ʈ�� ������ C��������Ʈ�� �ٲٰ� �ð��� ������ ��Ȱ��ȭ
            if (playerHeart.Heart == survivHp)
            {
                spriteRenderer.sprite = spriteC;
                yield return new WaitForSeconds(waitSeconds);
                gameObject.SetActive(false);
            }
            else if (isSwitch)
            // ��ҿ� ��������Ʈ A,B�� �ð����� �ٲ۴�
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
