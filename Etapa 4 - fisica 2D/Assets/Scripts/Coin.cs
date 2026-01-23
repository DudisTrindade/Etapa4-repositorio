using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valor = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Carro"))
        {
            ScoreManager.instance.AddScore(valor);
            Destroy(gameObject);
        }
    }
}
