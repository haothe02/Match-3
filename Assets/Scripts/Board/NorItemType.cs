using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorItemType : MonoBehaviour
{
    [SerializeField] private SpriteRenderer itemSpr;
    [SerializeField] private GameSettings gameSettings;
    public SpriteRenderer GetSpriteRenderer() { return itemSpr; }
    public void SetupSpr(string nameItem)
    {
        for (int i = 0; i < gameSettings.normalItem.Length; i++)
        {
            if (nameItem == gameSettings.normalItem[i].nameItem)
            {
                itemSpr.sprite = gameSettings.normalItem[i].itemSpr;
                break;
            }
        }
    }
}
