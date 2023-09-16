using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorSellPattern: ISeller
{
    public void PlayerInteraction()
    {
        Debug.Log("В продаже есть броня");
    }
}
