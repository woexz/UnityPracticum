using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepeChanger : MonoBehaviour
{
    public SpriteRenderer pepeRenderer; // ������ �� SpriteRenderer ������� Pepe
    public Sprite pepe_red; // ����� �������� ��� Pepe

    private void OnEnable()
    {
        // ������������� �� �������
        FireZone.OnPepeEnterFireZone += ChangePepeSprite;
    }

    private void OnDisable()
    {
        // ������������ �� �������
        FireZone.OnPepeEnterFireZone -= ChangePepeSprite;
    }

    private void ChangePepeSprite()
    {
        // ������ �������� Pepe
        pepeRenderer.sprite = pepe_red;
    }
}
