using UnityEngine;

public class ComportamientoFisicoColision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Aplicar fuerza en una dirección aleatoria al colisionar
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 fuerzaAleatoria = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            rb.AddForce(fuerzaAleatoria, ForceMode2D.Impulse);
        }
    }
}
