using UnityEngine;

/// <summary>
/// This script rotates a GameObject around a specified axis at a specified speed.
/// </summary>
public class Rotator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 2f;
    [SerializeField] Vector3 rotationAxis = Vector3.up;

    /// <summary>
    /// Update is called once per frame.
    /// </summary>
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);        
    }
}
