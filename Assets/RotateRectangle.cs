// RotateRectangle.cs - Rotates a single rectangle with arrow keys
using UnityEngine;

public class RotateRectangle : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float rotationInput = Input.GetAxis("Horizontal"); // Left/Right Arrow or A/D keys
        transform.Rotate(0, 0, -rotationInput * rotationSpeed * Time.deltaTime);
    }
}
