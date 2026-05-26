using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Camera mainCamera;
    private float lastCameraPositionX;

    [SerializeField] private ParallaxLayer[] backgroundLayers;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        float currentCameraPositionx = mainCamera.transform.position.x;
        float distanceToMove = currentCameraPositionx - lastCameraPositionX;
        lastCameraPositionX = currentCameraPositionx;

        foreach(ParallaxLayer layer in backgroundLayers)
        {
            layer.Move(distanceToMove);
        }
    }
}
