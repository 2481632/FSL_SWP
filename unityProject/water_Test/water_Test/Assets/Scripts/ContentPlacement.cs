using UnityEngine;
using System.Collections;

public class ContentPlacement : MonoBehaviour
{
    public GameObject waterPlane;

    private float cameraHeight;
    private float waterHeight;
    private float elevation;

    void Start()
    {
        // Alle 5 Sekunden die Wasserhöhe aktualisieren
        StartCoroutine(UpdateWaterRoutine());
    }

    private IEnumerator UpdateWaterRoutine()
    {
        while (true)
        {
            UpdateWater();
            yield return new WaitForSeconds(5f);
        }
    }

    private void UpdateWater()
    {
        if (waterPlane == null)
            return;

        // DU brauchst diese Felder als static oder Referenzen!
        cameraHeight = CameraHeightDetector.currentHeight;
        waterHeight  = API_WaterLevel.absoluteHeight;
        elevation    = API_Elevation.elevation_value;

        Vector3 pos = waterPlane.transform.position;
        pos.y = (waterHeight/100) - ((elevation + cameraHeight));
        waterPlane.transform.position = pos;
        Debug.Log("WaterHeight: " + waterHeight);
        Debug.Log("Elevation: " + elevation);
        Debug.Log("CameraHeight: " + cameraHeight);
        Debug.Log("Wasser aktualisiert → Y = " + pos.y);
    }
}







