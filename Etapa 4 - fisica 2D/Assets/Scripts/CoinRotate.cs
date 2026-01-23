using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float velocidade = 180f;

    void Update()
    {
        transform.Rotate(0, velocidade * Time.deltaTime, 0);
    }
}