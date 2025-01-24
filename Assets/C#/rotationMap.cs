using UnityEngine;

public class MapRotation : MonoBehaviour
{
    public float rotationSpeed = 90f; // Vitesse de la rotation
    private bool isRotating = false;

    void Update()
    {
        // Commence la rotation après 10 secondes
        if (Time.time >= 10f && !isRotating)
        {
            isRotating = true;
        }

        // Si la rotation est activée, fait tourner la caméra
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}