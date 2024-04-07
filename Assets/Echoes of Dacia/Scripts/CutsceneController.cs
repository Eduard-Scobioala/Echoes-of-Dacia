using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CutsceneController : MonoBehaviour
{
    public Sprite[] cutsceneImages;
    public Image displayImage;
    public float imageDisplayTime = 1f;
    public string nextSceneName;

    private int currentImageIndex = 0;

    private void Start()
    {
        if (cutsceneImages.Length > 0)
        {
            ShowNextImage(); // Start showing images from the beginning
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StopAllCoroutines(); // Stop the current waiting time
            ShowNextImage(); // Immediately show the next image
        }
    }

    private void ShowNextImage()
    {
        if (currentImageIndex < cutsceneImages.Length)
        {
            displayImage.sprite = cutsceneImages[currentImageIndex];
            currentImageIndex++;
            StartCoroutine(WaitAndShowNextImage(imageDisplayTime));
        }
        else
        {
            SceneManager.LoadScene(nextSceneName); // Load the next scene after the last image
        }
    }

    private IEnumerator WaitAndShowNextImage(float delay)
    {
        yield return new WaitForSeconds(delay);
        ShowNextImage(); // Show the next image after waiting
    }
}
