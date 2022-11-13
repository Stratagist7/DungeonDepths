using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensitivity = 270f;
    [SerializeField] private float headUpperLim = 50f;
    [SerializeField] private float headLowerLim = -80f;
    private float xRotation = 0f;

    [SerializeField] private Transform body;

    
    void Start()
    {
        // Locks and Hides the cursor, show cursor by pressing Escape
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Player can walk :o
    void Update()
    {
        // Gets the location of the mouse and adjusts it based on the sensitivity. Time.deltaTime allows it to update outside of a set framerate.
       float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xRotation -= mouseY;

        // Locks/clamps the X rotation so you can't break your neck :)
        xRotation = Mathf.Clamp(xRotation, headLowerLim, headUpperLim);

        // Rotates just the camera for looking up and down
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // Rotates the whole body with the camera when turning left and right
        body.Rotate(Vector3.up * mouseX);
    }
}
