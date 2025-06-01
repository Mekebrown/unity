using UnityEngine;

/// <summary>
/// Rotates the attached Light object to simulate the passing of a day.
/// The speed of rotation is determined by the number of real-world seconds for a full 24-hour cycle.
/// </summary>
[RequireComponent(typeof(Light))]
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day cycle in real seconds.")]
    [SerializeField] private float dayDurationInSeconds = 120f;

    private float rotationSpeed; // Degrees per second

    private void Start()
    {
        // 360 degrees represents a full day (sunrise to sunrise)
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    private void Update()
    {
        // Rotate around the X-axis to simulate the sun moving through the sky
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
