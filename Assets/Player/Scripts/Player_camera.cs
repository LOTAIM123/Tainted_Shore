using System.Numerics;
using UnityEngine;

public class Player_camera : MonoBehaviour
{

    public static Player_camera Instance;

    public float sensX;
    public float sensY;

    public bool updatingRotation;

    public Transform orientation;

    float xRotation;
    float yRotation;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if(updatingRotation) return;
        
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = UnityEngine.Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = UnityEngine.Quaternion.Euler(0, yRotation, 0);

    }

}
