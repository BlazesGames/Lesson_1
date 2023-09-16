using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotPattern : IPistol
{
    private bool isActive;
    public void Shoot(GameObject bullet, Transform pointBuletStart, ref int countBullet)
    {
        if (countBullet > 0)
        {
            GameObject.Instantiate(bullet, pointBuletStart.position, pointBuletStart.rotation);
            countBullet--;
        }
    }

    public void PistolActive() => isActive = true;
    public void PistolDisactive() => isActive = false;
}
