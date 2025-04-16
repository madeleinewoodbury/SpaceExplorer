using UnityEngine;

/// <summary>
/// Controls the movement of a satellite object in the game.
/// The satellite moves up and down in a sinusoidal pattern and rotates around its vertical axis.
/// </summary>
public class SatelliteMovement : MonoBehaviour
{
    /// <summary>
    /// The amplitude of the vertical sinusoidal movement.
    /// Determines how far the satellite moves up and down.
    /// </summary>
    public float verticalAmplitude = 1.0f;

    /// <summary>
    /// The frequency of the vertical sinusoidal movement.
    /// Determines how fast the satellite moves up and down.
    /// </summary>
    public float verticalFrequency = 1.0f;

    /// <summary>
    /// The speed at which the satellite rotates around its vertical axis.
    /// Measured in degrees per second.
    /// </summary>
    public float rotationSpeed = 10.0f;

    /// <summary>
    /// The initial position of the satellite when the script starts.
    /// Used as the reference point for the vertical movement.
    /// </summary>
    private Vector3 startPosition;


    /// <summary>
    /// Called once per frame.
    /// Updates the satellite's position to create a vertical sinusoidal movement
    /// and rotates the satellite around its vertical axis.
    /// </summary>
    void Update() 
    {
        // Rotate the satellite slightly
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
