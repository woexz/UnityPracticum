using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepeChanger : MonoBehaviour
{
    public SpriteRenderer pepeRenderer; // Ссылка на SpriteRenderer объекта Pepe
    public Sprite pepe_red; // Новая картинка для Pepe

    private void OnEnable()
    {
        // Подписываемся на событие
        FireZone.OnPepeEnterFireZone += ChangePepeSprite;
    }

    private void OnDisable()
    {
        // Отписываемся от события
        FireZone.OnPepeEnterFireZone -= ChangePepeSprite;
    }

    private void ChangePepeSprite()
    {
        // Меняем картинку Pepe
        pepeRenderer.sprite = pepe_red;
    }
}
