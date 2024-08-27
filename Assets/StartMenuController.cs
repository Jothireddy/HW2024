using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Scenes/SampleScene"); // Replace with the name of your game scene
    }
}
