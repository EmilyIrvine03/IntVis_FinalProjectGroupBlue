using UnityEngine;

public class NoOutlineBehind : MonoBehaviour
{
    public Transform cameraTransform;
    public Outline outline;

    void Update()
    {
        if (cameraTransform)
        {
            // Convert local forward into world direction (same as your example)
            Vector3 forward = transform.TransformDirection(Vector3.forward);

            // Direction from this object → camera (same pattern you used)
            Vector3 toCamera = Vector3.Normalize(cameraTransform.position - transform.position);

            // If camera is behind, disable outline
            if (Vector3.Dot(forward, toCamera) < 0)
            {
                outline.OutlineWidth = 0f;
            }
            else
            {
                outline.OutlineWidth = 8f;
            }
        }
    }
}
