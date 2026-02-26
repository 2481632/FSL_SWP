using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateLocationText : MonoBehaviour
{
    public TMP_Text location;

    private void Update()
    {
        location.text = $"Latitude: {Location.Instance.latitude}\nLongitude: {Location.Instance.longitude}\nAltitude: {Location.Instance.altitude}\n\nMessage:\n{Location.Instance.message}";
    }
}
