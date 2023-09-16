using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform pointBuletStart;
    [SerializeField] private int countBullet;
    [SerializeField] private GameObject[] allPistol;

    private IPistol _pistol;

    private void Awake()
    {
        allPistol[0].SetActive(true);
        SetPistol(new OneShotPattern());
    }

    void Update()
    {
        ChenegePistol();
        ShootPistol();
    }

    public void ShootPistol()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _pistol.Shoot(bullet, pointBuletStart, ref countBullet);
        }
    }

    void ChenegePistol()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DiableActivPistol();
            allPistol[0].SetActive(true);
            SetPistol(new OneShotPattern());

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DiableActivPistol();
            allPistol[1].SetActive(true);
            SetPistol(new InfinitePattern());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DiableActivPistol();
            allPistol[2].SetActive(true);
            SetPistol(new ThreeShotsPattern());
        }
    }

    private void DiableActivPistol()
    {
        for (int i = 0; i < allPistol.Length; i++)
        {
            if (allPistol[i])
                allPistol[i].SetActive(false);
        }
    }

    private void SetPistol(IPistol pistol)
    {
        _pistol?.PistolDisactive();
        _pistol = pistol;
        _pistol.PistolActive();
    }
}
