using UnityEngine;

public class ZonaImpulso : MonoBehaviour
{
    public float fuerzaImpulso = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("¡Impulso!");
        // Impulsar objetos que entren en la zona
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(Vector2.right * fuerzaImpulso, ForceMode2D.Impulse);
        }
    }
}
