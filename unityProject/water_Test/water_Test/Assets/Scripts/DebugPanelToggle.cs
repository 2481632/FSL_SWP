using UnityEngine;
using UnityEngine.UI;

public class DebugPanelToggle : MonoBehaviour
{
    [SerializeField] private GameObject debugPanel;

    void Start()
    {
        if (debugPanel != null)
            debugPanel.SetActive(false);
    }

    public void ToggleDebugPanel()
    {
        if (debugPanel == null) return;

        debugPanel.SetActive(!debugPanel.activeSelf);
    }
}

