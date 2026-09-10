using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    void Start()
    {
        Renderer objectRenderer = GetComponent<Renderer>();
        objectRenderer.material.color = Color.yellow;
    }
}