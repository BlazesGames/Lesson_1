using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeShotsPattern : IPistol
{
    private bool isActive;
    private int shootBullet = 3;
    private float distansBullet;

    public void Shoot(GameObject bullet, Transform pointBuletStart, ref int countBullet)
    {
        if (countBullet > 2)
        {
            for (int i = 0; i < shootBullet; i++)
            {
                GameObject bufBullet = GameObject.Instantiate(bullet, pointBuletStart.position, pointBuletStart.rotation);
                bufBullet.transform.position = new Vector3(pointBuletStart.transform.position.x - distansBullet, pointBuletStart.transform.position.y, pointBuletStart.transform.position.z);
                distansBullet += 0.2f;
            }
            distansBullet = 0;
            countBullet -= 3;
        }
    }

    public void PistolActive() => isActive = true;
    public void PistolDisactive() => isActive = false;

}
