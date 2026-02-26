using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class API_WaterLevel : MonoBehaviour
{
    [Header("API Settings")]
    public string apiUrl = "http://87.77.67.118:5000/";
    public float updateInterval = 5f;

    [Header("UI")]
    public TextMeshProUGUI displayText;

    public static float waterHeightOverGaugeZero_cm = 0f; // cm
    public static float gaugeZeroHeight_m = 0f;           // m
    public static float waterHeightOverNN_cm = 0f;        // cm

    // Wichtig: global verfügbar für ContentPlacement
    public static float absoluteHeight = 0f;

    void Start()
    {
        StartCoroutine(UpdateDataRoutine());
    }

    IEnumerator UpdateDataRoutine()
    {
        while (true)
        {
            yield return StartCoroutine(GetAPIData());
            yield return new WaitForSeconds(updateInterval);
        }
    }

    IEnumerator GetAPIData()
    {
        if (displayText != null)
            displayText.text = "Lade Wasserpegel...";

        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            request.SetRequestHeader("User-Agent", "Unity");
            request.SetRequestHeader("Accept-Encoding", "identity");
            request.timeout = 10;

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string jsonResponse = request.downloadHandler.text;
                ProcessPegelData(jsonResponse);
            }
            else
            {
                if (displayText != null)
                {
                    displayText.text =
                        "FEHLER:\n" +
                        request.error + "\n" +
                        "HTTP Code: " + request.responseCode;
                }
            }
        }
    }

    void ProcessPegelData(string json)
    {
        try
        {
            PegelData data = JsonUtility.FromJson<PegelData>(json);

            // Schutz: Keine Daten
            if (data == null || data.timeseries == null || data.timeseries.Length == 0)
            {
                if (displayText != null)
                    displayText.text = "Keine Daten empfangen.";

                return;
            }

            Timeseries ts = data.timeseries[0];

            // Prüfen auf null
            if (ts.currentMeasurement == null || ts.gaugeZero == null)
            {
                if (displayText != null)
                    displayText.text = "Ungültige API-Daten.";

                return;
            }

            // float relativeHeight = ts.currentMeasurement.value; // cm über Pegelnull
            // float gaugeZeroHeight = ts.gaugeZero.value;         // m über Normalnull

            // // absolute Höhe in cm über Normalnull
            // absoluteHeight = relativeHeight + (gaugeZeroHeight * 100f);
            waterHeightOverGaugeZero_cm = ts.currentMeasurement.value; // cm
            gaugeZeroHeight_m = ts.gaugeZero.value;                    // m
            waterHeightOverNN_cm = waterHeightOverGaugeZero_cm + (gaugeZeroHeight_m * 100f);

            // optional: legacy
            absoluteHeight = waterHeightOverNN_cm;

            if (displayText != null)
            {
                displayText.text =
                    "Höhe des Gewässers über Pegelnull: " + waterHeightOverGaugeZero_cm + " cm\n" +
                    "Pegelnullstand: " + gaugeZeroHeight_m + " m\n" +
                    "Höhe über Normalnull: " + waterHeightOverNN_cm + " cm";
            }
        }
        catch (System.Exception e)
        {
            if (displayText != null)
                displayText.text = "Parse-Fehler:\n" + e.Message;
        }
    }
}

[System.Serializable]
public class PegelData
{
    public Timeseries[] timeseries;
}

[System.Serializable]
public class Timeseries
{
    public CurrentMeasurement currentMeasurement;
    public GaugeZero gaugeZero;
}

[System.Serializable]
public class CurrentMeasurement
{
    public float value;
}

[System.Serializable]
public class GaugeZero
{
    public float value;
}

