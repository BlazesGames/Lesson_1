using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsSellPattern : ISeller
{
    public void PlayerInteraction()
    {
        Debug.Log("Тебе повезло, я могу продать тебе зелья");
    }
    
}
