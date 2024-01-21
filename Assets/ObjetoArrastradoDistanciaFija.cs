using UnityEngine;

public class ObjetoArrastradoDistanciaFija : MonoBehaviour
{
    public Transform objetoArrastrador;
    public float distanciaFija = 2f;

    private void Update()
    {
        // Mantener el objeto a una distancia fija del objeto arrastrador
        Vector3 direccion = objetoArrastrador.position - transform.position;
        direccion.Normalize();
        transform.position = objetoArrastrador.position - (direccion * distanciaFija);
    }
}
