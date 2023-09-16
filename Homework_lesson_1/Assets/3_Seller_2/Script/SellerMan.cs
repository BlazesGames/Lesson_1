using UnityEngine;

public abstract class SellerMan : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Sell();
    }

    public abstract void Sell();
}
