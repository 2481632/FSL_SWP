using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class BuildingLevel : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    private int level = 0;

    const int minLevel = -3;
    const int maxLevel = 45; // das höchste Haus in Berlin hat 45 Stockwerke

    const int LevelHeight = 3;

    void Start()
    {
        if (dropdown != null)
        {
            // Dropdown mit Werten von -3 bis 45 füllen
            dropdown.ClearOptions();
            List<string> optionen = new List<string>();
            
            for (int i = minLevel; i <= maxLevel; i++)
            {
                // Schönere Formatierung mit "Floor: " Prefix
                string bezeichnung = FormatiereLevelBezeichnung(i);
                optionen.Add(bezeichnung);
            }
            
            dropdown.AddOptions(optionen);
            
            // Standardwert auf 0 setzen (Index 3, da -3, -2, -1, 0...)
            dropdown.value = 3;
            level = 0;
            
            // Listener hinzufügen
            dropdown.onValueChanged.AddListener(OnLevelGeaendert);
            
            // Dropdown Styling
            StyleDropdown();
        }
    }

    string FormatiereLevelBezeichnung(int levelNummer)
    {
        if (levelNummer < 0)
        {
            // Untergeschosse: "Floor: B1", "Floor: B2", "Floor: B3"
            return "Floor: B" + Mathf.Abs(levelNummer);
        }
        else if (levelNummer == 0)
        {
            // Erdgeschoss
            return "Floor: Ground";
        }
        else
        {
            // Normale Stockwerke: "Floor: 1", "Floor: 2" etc.
            return "Floor: " + levelNummer;
        }
    }

    void StyleDropdown()
    {
        // Caption Text (der angezeigte Wert) stylen
        if (dropdown.captionText != null)
        {
            dropdown.captionText.fontSize = 28;
            dropdown.captionText.color = new Color(220f/255f, 220f/255f, 220f/255f, 1f); // Hellgrau
            dropdown.captionText.alignment = TextAlignmentOptions.MidlineLeft;
        }
        
        // Item Text (die Einträge in der Liste) stylen
        if (dropdown.itemText != null)
        {
            dropdown.itemText.fontSize = 20;
            dropdown.itemText.color = new Color(220f/255f, 220f/255f, 220f/255f, 1f);
            dropdown.itemText.alignment = TextAlignmentOptions.MidlineLeft;
        }
        
        // Template Größe anpassen (max. 8 Items sichtbar)
        RectTransform template = dropdown.template;
        if (template != null)
        {
            template.sizeDelta = new Vector2(template.sizeDelta.x, 320); // 8 Items à 40px
        }
    }

    void OnLevelGeaendert(int index)
    {
        // Index in tatsächlichen Wert umrechnen (-3 ist Index 0)
        level = index + minLevel;
        Debug.Log("Level gesetzt auf: " + level + " (" + FormatiereLevelBezeichnung(level) + ")");
        VerarbeiteLevel(level);
    }

    void VerarbeiteLevel(int neuesLevel)
    {
        // Hier kannst du mit dem Level arbeiten
        int hoehe = GetLevelOffset();
        Debug.Log("Verarbeite Level: " + neuesLevel + " (Höhe: " + hoehe + "m)");
        
        // Beispiel: Wasserhöhe anpassen
        // WaterManager.Instance.SetReferenceHeight(hoehe);
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetLevelOffset()
    {
        return (level * LevelHeight);
    }

    // Optional: Level programmatisch setzen
    public void SetLevel(int neuesLevel)
    {
        if (neuesLevel >= minLevel && neuesLevel <= maxLevel)
        {
            level = neuesLevel;
            dropdown.value = neuesLevel - minLevel;
            Debug.Log("Level programmatisch gesetzt auf: " + FormatiereLevelBezeichnung(neuesLevel));
        }
        else
        {
            Debug.LogWarning("Level " + neuesLevel + " außerhalb des gültigen Bereichs (" + minLevel + " bis " + maxLevel + ")");
        }
    }
    
    // Zusätzliche Hilfsfunktion: Level-Name abrufen
    public string GetLevelName()
    {
        return FormatiereLevelBezeichnung(level);
    }
    
    // Höhe in Metern für UI-Anzeige
    public string GetLevelHeightString()
    {
        int hoehe = GetLevelOffset();
        return hoehe + "m";
    }
}
// using UnityEngine;
// using TMPro;
// using System.Collections.Generic;

// public class BuildingLevel : MonoBehaviour
// {
//     public TMP_Dropdown dropdown;
//     private int level = 0;

//     const int minLevel = -3;
//     const int maxLevel = 45; // das höchste Haus in Berlin hat 45 Stockwerke

//     const int LevelHeight = 3;

//     void Start()
//     {
//         if (dropdown != null)
//         {
//             // Dropdown mit Werten von -3 bis 45 füllen
//             dropdown.ClearOptions();
//             List<string> optionen = new List<string>();
            
//             for (int i = minLevel; i <= maxLevel; i++)
//             {
//                 optionen.Add(i.ToString());
//             }
            
//             dropdown.AddOptions(optionen);
            
//             // Standardwert auf 0 setzen (Index 3, da -3, -2, -1, 0...)
//             dropdown.value = 3;
//             level = 0;
            
//             // Listener hinzufügen
//             dropdown.onValueChanged.AddListener(OnLevelGeaendert);
//         }
//     }

//     void OnLevelGeaendert(int index)
//     {
//         // Index in tatsächlichen Wert umrechnen (-3 ist Index 0)
//         level = index + minLevel;
//         Debug.Log("Level gesetzt auf: " + level);
//         VerarbeiteLevel(level);
//     }


//     void VerarbeiteLevel(int neuesLevel)
//     {
//         // Hier kannst du mit dem Level arbeiten
//         Debug.Log("Verarbeite Level: " + neuesLevel);
//     }

//     public int GetLevel()
//     {
//         return level;
//     }

//     public int GetLevelOffset()
//     {
//         return (level * LevelHeight);
//     }

//     // Optional: Level programmatisch setzen
//     public void SetLevel(int neuesLevel)
//     {
//         if (neuesLevel >= minLevel && neuesLevel <= maxLevel)
//         {
//             level = neuesLevel;
//             dropdown.value = neuesLevel - minLevel; // +3 wegen Offset
//         }
//     }
// }