using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public Transform CameraPos;
    void Update()
    {
        transform.position = CameraPos.position;
    }
}
