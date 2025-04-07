using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniQuizManager : MonoBehaviour
{
    public GameObject questionPanel;
    public GameObject correctPopup;
    public GameObject tryAgainPopup;

    // Called when an answer (A, B, or C) is clicked
    public void OnAnswerSelected(string choice)
    {
        if (choice == "B") // Change this to your correct answer
        {
            questionPanel.SetActive(false);
            correctPopup.SetActive(true);
        }
        else
        {
            questionPanel.SetActive(false);
            tryAgainPopup.SetActive(true);
        }
    }

    // Called when "Back" is pressed on Try Again popup
    public void RetryQuestion()
    {
        tryAgainPopup.SetActive(false);
        questionPanel.SetActive(true);
    }

    // Called when "Continue" is pressed on Well Done popup
    public void ContinueAfterCorrect()
    {
        correctPopup.SetActive(false);

        // Example: Load next scene
        // SceneManager.LoadScene("NextScene");

        // Or continue with your game logic here
        Debug.Log("Player continues after answering correctly.");
    }

}
