using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        // �����Ӹ��� ������� ���Ͻ�Ų��.
        transform.Translate(0, -0.07f, 0);

        // ȭ�� ������ ������ ������Ʈ�� �����Ѵ�.
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // �浹 ����
        Vector2 p1 = transform.position;             // ȭ�� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; // �÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;                             // ȭ�� �ݰ�
        float r2 = 1.0f;                             // �÷��̾� �ݰ�

        if (d < r1 + r2)
        {
            // ���� ��ũ��Ʈ�� �÷��̾�� �浹�� ���� ���Ѵ�
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            // �浹�� ���� ȭ���� �����
            Destroy(gameObject);
        }
    }
}