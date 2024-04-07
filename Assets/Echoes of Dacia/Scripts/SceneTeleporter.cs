using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter : MonoBehaviour
{
    public string targetSceneName; // The name of the scene to load

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Make sure it's the player entering the trigger
        {
            if (targetSceneName == "Exit")
            {
                Application.Quit();
            }

            SceneManager.LoadScene(targetSceneName);
        }
    }
}