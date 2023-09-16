using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seller : MonoBehaviour
{
    private ISeller _seller;

    public void Sell(ISeller seller)
    {
        SetSell(seller);
    }

    public void SetSell(ISeller seller)
    {
        _seller?.PlayerInteraction();
        _seller = seller;
    }
}
