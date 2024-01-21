using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("¡Trigger activado");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("¡Collision activado");
    }
}
