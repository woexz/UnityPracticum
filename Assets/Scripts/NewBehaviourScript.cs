using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения персонажа

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Получаем компонент Rigidbody2D на объекте
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Получаем ввод от пользователя по осям X и Y
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Создаем вектор движения
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Двигаем персонажа
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
