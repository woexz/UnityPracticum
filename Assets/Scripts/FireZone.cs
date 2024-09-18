using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FireZone : MonoBehaviour
{
    // ������� ��� ���������� �����������
    public static event Action OnPepeEnterFireZone;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // ��������, ��� ��� Pepe
        {
            // ������� �������, ���� Pepe ����� � ����
            OnPepeEnterFireZone?.Invoke();
        }
    }
}
