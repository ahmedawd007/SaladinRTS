using UnityEngine;

[CreateAssetMenu(menuName = "RTS/RTSConfig")]
public class RTSConfig : ScriptableObject
{
    public float cameraPanSpeed = 4f;
    public float cameraZoomSpeed = 5f;
    public float minZoom = 3f;
    public float maxZoom = 12f;
}