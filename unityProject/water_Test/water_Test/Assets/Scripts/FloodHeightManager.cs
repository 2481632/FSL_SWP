using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class FloodHeightManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI floodDisplay;

    private float floodHeight;
    private float waterHeight;
    private float elevation;

    void Start()
    {
        // Alle 5 Sekunden die Wasserhöhe aktualisieren
        StartCoroutine(UpdateWaterLevel());
    }

    private IEnumerator UpdateWaterLevel()
    {
        while (true)
        {
            UpdateWater();
            yield return new WaitForSeconds(5f);
        }
    }

    private void UpdateWater()
    {        
        if (floodDisplay != null)
            floodDisplay.text = "Lade Fluthöhe...";

        waterHeight  = API_WaterLevel.absoluteHeight/100;
        elevation    = API_Elevation.elevation_value;

        floodHeight = waterHeight - elevation;

        Debug.Log("WaterHeight: " + floodHeight);

        if (floodDisplay != null)
            floodDisplay.text = "Fluthöhe: " + floodHeight;

    }

    
}
