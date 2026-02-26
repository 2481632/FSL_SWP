using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterHeightController : MonoBehaviour
{
    [Header("References")]
    public GameObject arWater;

    public BuildingLevel buildingLevel;
    public Slider heightSlider;

    [Header("Water Height Settings (meters above ground)")]
    public float minWaterHeight = 0f;
    public float maxWaterHeight = 3f;

    [Header("Optional UI")]
    public TextMeshProUGUI waterText;

    void Start()
    {
        if (heightSlider != null)
        {
            heightSlider.minValue = minWaterHeight;
            heightSlider.maxValue = maxWaterHeight;
            heightSlider.value = minWaterHeight;

            heightSlider.onValueChanged.AddListener(UpdateWaterHeight);
            Debug.Log("Height Slider Value:" + heightSlider.value);
        }

        UpdateWaterHeight(heightSlider.value);
    }

    void UpdateWaterHeight(float waterHeight)
    {
        if (arWater == null)
            return;

        // Sicherheit: Boden noch nicht erkannt
        if (CameraHeightDetector.currentHeight <= 0f)
            return;

        float cameraY = Camera.main.transform.position.y;
        float groundY = cameraY - CameraHeightDetector.currentHeight;

        Vector3 pos = arWater.transform.position;
        pos.y = groundY + waterHeight + buildingLevel.GetLevelOffset();
        arWater.transform.position = pos;

        if (waterText != null)
        {
            waterText.text = "Wasserhöhe: " + waterHeight.ToString("F2") + " m";
        }
    }

    void Update()
    {
        // Optional: Wasser folgt Kamera, falls sich Tracking leicht ändert
        if (heightSlider != null)
            UpdateWaterHeight(heightSlider.value);
    }
}


