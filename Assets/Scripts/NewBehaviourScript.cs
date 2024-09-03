using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ���������

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // �������� ��������� Rigidbody2D �� �������
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �������� ���� �� ������������ �� ���� X � Y
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // ������� ������ ��������
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // ������� ���������
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
