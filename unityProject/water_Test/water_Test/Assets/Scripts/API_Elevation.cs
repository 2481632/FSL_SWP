using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class API_Elevation : MonoBehaviour
{
    public float x_cord = 52.460f;
    public float y_cord = 13.297f;

    public static float elevation_value;

    [Header("API Settings")]
    public string apiUrl;
    public float updateInterval = 5f;

    [Header("UI")]
    public TextMeshProUGUI displayText;

    void Start()
    {
        StartCoroutine(UpdateDataRoutine());
    }

    IEnumerator UpdateDataRoutine()
    {
        while (true)
        {
            if (Location.Instance != null && !float.IsNaN(Location.Instance.latitude))
            {
                x_cord = Location.Instance.latitude;
                y_cord = Location.Instance.longitude;
            }
            else
            {
                Debug.LogWarning("Location.Instance NULL oder ungültige Koordinaten.");
            }

            // Für API korrekt formatieren
            string lat = x_cord.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string lon = y_cord.ToString(System.Globalization.CultureInfo.InvariantCulture);

            // API URL erstellen
            apiUrl = $"https://api.open-meteo.com/v1/elevation?latitude={lat}&longitude={lon}";

            Debug.Log("API Elevation URL: " + apiUrl);

            yield return StartCoroutine(GetAPIData());
            yield return new WaitForSeconds(updateInterval);
        }
    }

    IEnumerator GetAPIData()
    {
        if (displayText != null)
            displayText.text = "Lade Höhe...";

        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            request.SetRequestHeader("User-Agent", "Unity");
            request.SetRequestHeader("Accept-Encoding", "identity");
            request.timeout = 10;

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string jsonResponse = request.downloadHandler.text;
                ProcessElevationData(jsonResponse);
            }
            else
            {
                if (displayText != null)
                {
                    displayText.text =
                        $"FEHLER:\n{request.error}\nHTTP Code: {request.responseCode}";
                }
            }
        }
    }

    void ProcessElevationData(string json)
    {
        try
        {
            ElevationData data = JsonUtility.FromJson<ElevationData>(json);

            // API liefert ein Array → immer erstes Element
            if (data.elevation != null && data.elevation.Length > 0)
            {
                elevation_value = data.elevation[0];

                if (displayText != null)
                    displayText.text = $"Wir befinden uns auf: {elevation_value} m";

                Debug.Log("Elevation API – Aktuell: " + elevation_value + " m");
            }
            else
            {
                if (displayText != null)
                    displayText.text = "Keine Höhen-Daten erhalten.";
            }
        }
        catch (System.Exception e)
        {
            if (displayText != null)
                displayText.text = $"Parse-Fehler:\n{e.Message}";
        }
    }
}

[System.Serializable]
public class ElevationData
{
    public float[] elevation;
}
