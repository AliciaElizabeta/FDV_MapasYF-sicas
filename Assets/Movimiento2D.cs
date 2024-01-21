using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movimiento2D : MonoBehaviour
{
    public float velocidad = 5f;
    public float PotenciaDeSaltoInicial = 10f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public int Puntuacion { get; private set; }
    public int PuntuacionParaIncrementoSalto = 50;
    private float potenciaDeSaltoActual;
    public TMPro.TextMeshProUGUI textoPuntuacion;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Mover();

        // Detectar el salto
        if (Input.GetButtonDown("Jump"))
        {
            Saltar();
        }

        // Voltear el sprite según la dirección del movimiento
        if (rb.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (rb.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    private void Mover()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector2 movimiento = new Vector2(movimientoHorizontal, 0f);
        rb.velocity = new Vector2(movimiento.x * velocidad, rb.velocity.y);
    }

    private void Saltar()
    {
        // Verificar si el personaje está en el suelo antes de saltar
        rb.velocity = new Vector2(rb.velocity.x, PotenciaDeSaltoInicial);

    }

    public void AumentarPuntuacion(int incremento)
    {
        Puntuacion += incremento;
        ActualizarTextoPuntuacion();
    }

    public void AumentarPotenciaSalto(int incremento)
    {
        potenciaDeSaltoActual += incremento;
    }

    private void ActualizarTextoPuntuacion()
    {
        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = "Puntuación: " + Puntuacion.ToString();
        }
    }
}