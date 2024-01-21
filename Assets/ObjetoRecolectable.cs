using UnityEngine;

public class ObjetoRecolectable : MonoBehaviour
{
    public int puntosDeIncremento = 10;
    public int incrementoDePotenciaDeSalto = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Movimiento2D jugador = other.GetComponent<Movimiento2D>();

            if (jugador != null)
            {
                // Aumentar la puntuación del jugador
                jugador.AumentarPuntuacion(puntosDeIncremento);

                // Comprobar si la puntuación alcanza el valor de incremento de potencia de salto
                if (jugador.Puntuacion >= jugador.PuntuacionParaIncrementoSalto)
                {
                    jugador.AumentarPotenciaSalto(incrementoDePotenciaDeSalto);
                }

                // Destruir el objeto recolectable
                Destroy(gameObject);
            }
        }
    }
}
