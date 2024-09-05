using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FireZone : MonoBehaviour
{
    // Событие для оповещения подписчиков
    public static event Action OnPepeEnterFireZone;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Убедимся, что это Pepe
        {
            // Вызовем событие, если Pepe вошел в зону
            OnPepeEnterFireZone?.Invoke();
        }
    }
}
