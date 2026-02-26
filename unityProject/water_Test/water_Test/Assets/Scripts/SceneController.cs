using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Name oder Index der Demo-Szene
    public string demoSceneName = "DemoScene";
    public string mainSceneName = "SampleScene";
    
    // Methode zum Wechseln zur Demo-Szene
    public void LoadDemoScene()
    {
        SceneManager.LoadScene(demoSceneName);
    }
    
    // Methode zum Zurückkehren zur Hauptszene
    public void LoadMainScene()
    {
        SceneManager.LoadScene(mainSceneName);
    }
    
    // Alternative: Mit Scene-Index arbeiten
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}