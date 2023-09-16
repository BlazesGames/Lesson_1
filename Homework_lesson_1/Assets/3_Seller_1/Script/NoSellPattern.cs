using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSellPattern : ISeller
{
    public void PlayerInteraction()
    {
        Debug.Log("Сегодня я ничего не продаю");
    }   
}
