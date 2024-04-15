using UnityEngine;
using System.Collections;

public class ElevateCylinder : MonoBehaviour
{
    public GameObject cylinder;  // Drag your cylinder GameObject here in the Inspector
    public float elevationHeight = 5f; // How high the cylinder should rise
    public float duration = 10f; // Duration for which the cylinder stays elevated

    private Vector3 originalPosition;

    void Start()
    {
        // Store the original position of the cylinder
        originalPosition = cylinder.transform.position;
    }

    void Update()
    {
        // Check if the 'E' key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(ElevateAndLower());
        }
    }

    IEnumerator ElevateAndLower()
    {
        // Calculate the target elevated position
        Vector3 elevatedPosition = new Vector3(originalPosition.x, originalPosition.y + elevationHeight, originalPosition.z);

        // Move the cylinder to the elevated position
        cylinder.transform.position = elevatedPosition;

        // Wait for the specified duration
        yield return new WaitForSeconds(duration);

        // Move the cylinder back to its original position
        cylinder.transform.position = originalPosition;
    }
}
