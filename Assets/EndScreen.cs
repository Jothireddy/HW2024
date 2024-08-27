using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Scenes/SampleScene"); // Replace with the name of your game scene
    }
}
