using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSeller : MonoBehaviour
{
    [SerializeField] private Seller seller;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            switch (other.GetComponent<Player>().timesOfDay)
            {
                case Player.TimesOfDay.Day:
                    seller.Sell(new PotionsSellPattern());
                    break;
                case Player.TimesOfDay.Morning:
                    seller.Sell(new ArmorSellPattern());
                    break;
                case Player.TimesOfDay.Night:
                    seller.Sell(new NoSellPattern());
                    break;
            }
        }
    }
}
