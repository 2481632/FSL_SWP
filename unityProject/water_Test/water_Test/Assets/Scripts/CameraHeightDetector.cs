using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;

public class CameraHeightDetector : MonoBehaviour
{
    private ARPlaneManager planeManager;
    private Camera arCamera;

    // Wichtig: static, damit andere Scripts darauf zugreifen können
    public static float currentHeight = 0f;

    [Header("UI")]
    public TextMeshProUGUI heightText;

    void Start()
    {
        planeManager = FindObjectOfType<ARPlaneManager>();
        arCamera = Camera.main;

        if (planeManager == null)
            Debug.LogWarning("CameraHeightDetector: Kein ARPlaneManager gefunden.");

        if (arCamera == null)
            Debug.LogWarning("CameraHeightDetector: Keine Kamera gefunden.");
    }

    void Update()
    {
        if (planeManager == null || arCamera == null)
        {
            if (heightText != null)
                heightText.text = "Fehler: AR-Komponenten fehlen.";
            return;
        }

        float height = GetCameraHeightAboveGround();

        if (height > 0)
        {
            currentHeight = height;

            if (heightText != null)
                heightText.text = "Höhe: " + currentHeight.ToString("F2") + " m";
        }
        else
        {
            if (heightText != null)
                heightText.text = "Boden wird gesucht...";
        }
    }

    float GetCameraHeightAboveGround()
    {
        float lowestPlaneY = float.MaxValue;
        bool foundPlane = false;

        foreach (var plane in planeManager.trackables)
        {
            if (plane.alignment == UnityEngine.XR.ARSubsystems.PlaneAlignment.HorizontalUp)
            {
                float y = plane.transform.position.y;

                if (y < lowestPlaneY)
                {
                    lowestPlaneY = y;
                    foundPlane = true;
                }
            }
        }

        if (foundPlane)
        {
            return arCamera.transform.position.y - lowestPlaneY;
        }

        return -1f;
    }
}


