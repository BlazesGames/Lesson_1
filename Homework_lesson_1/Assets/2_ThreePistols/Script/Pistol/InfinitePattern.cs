using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePattern : IPistol
{
    private bool isActive;

    public void Shoot(GameObject bullet, Transform pointBuletStart, ref int countBullet)
    {
        GameObject.Instantiate(bullet, pointBuletStart.position, pointBuletStart.rotation);
    }

    public void PistolActive() => isActive = true;
    public void PistolDisactive() => isActive = false;

}
