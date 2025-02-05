using UnityEngine;

public class WelcomeManager : MonoBehaviour
{
    public GameObject welcomePanel; // Assign the WelcomePanel in the Inspector
    public GameObject heartModel;   // Assign the heart model in the Inspector

    void Start()
    {
        welcomePanel.SetActive(true);  // Show the welcome screen at start
        heartModel.SetActive(false);   // Hide the heart model initially
    }

    public void StartHeartLesson()
    {
        welcomePanel.SetActive(false); // Hide the welcome panel
        heartModel.SetActive(true);    // Show the heart model
    }
}

