using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IPistol
{
    void Shoot(GameObject bullet, Transform pointBuletStart, ref int countBullet);
    void PistolActive();
    void PistolDisactive();
}
