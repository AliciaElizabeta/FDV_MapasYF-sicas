using UnityEngine;

public class SaltoAPlataforma : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision con " + collision.gameObject.name);
        if (collision.gameObject.tag =="InvPlatform")
        {
            collision.gameObject.GetComponent<Renderer>().enabled = true;
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("ObjetosFisicos"))
            // Verificar si el jugador colisiona con la plataforma
            if (collision.gameObject.CompareTag("InvPlatform"))
        {
            // Hacer que el jugador sea hijo de la plataforma
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

            // Desvincular al jugador de la plataforma
            transform.parent = null;
        }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("¡Trigger activado");
    }
}