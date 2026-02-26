using UnityEngine;
using TMPro;

public class DebugPanel : MonoBehaviour
{
    public TextMeshProUGUI debugText;

    void Update()
    {
        if (debugText == null)
        {
            Debug.LogError("DebugText ist NULL!");
            return;
        }
        debugText.text =
            $"GPS\n" +
            $"Lat:  { Location.Instance.latitude }\n" +
            $"Lon:  { Location.Instance.longitude }\n" +
            $"Elev: { API_Elevation.elevation_value } m\n\n" +

            $"WASSER\n" +
            $"Höhe Gewässer über Pegelnull:  { API_WaterLevel.waterHeightOverGaugeZero_cm:F1} m\n" +
            $"Pegelnullstand:      { API_WaterLevel.gaugeZeroHeight_m:F2} m\n" +
            $"Höhe über NN:        { API_WaterLevel.waterHeightOverGaugeZero_cm:F1} m\n\n" +

            $"KAMERA\n" +
            $"Kamerahöhe: { CameraHeightDetector.currentHeight } m";
    }
}

