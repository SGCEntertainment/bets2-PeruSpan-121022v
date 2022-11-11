using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTeam : MonoBehaviour
{
    public Image spriteRenderer;
    public Sprite[] sprites;

    public void Click()
    {
        spriteRenderer.sprite = null;
        int random = 0;
        random = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[random];
    }
}
