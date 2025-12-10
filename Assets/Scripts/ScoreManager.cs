using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.HasKey("Real"))
        {
            int real = PlayerPrefs.GetInt("Real");
            if (real == 1)
            {
                Debug.Log("erste if");

                if (SceneManager.GetActiveScene().name == "answer1" || SceneManager.GetActiveScene().name == "answer4" || SceneManager.GetActiveScene().name == "answer6" || SceneManager.GetActiveScene().name == "answer7" || SceneManager.GetActiveScene().name == "answer10" || SceneManager.GetActiveScene().name == "answer14" || SceneManager.GetActiveScene().name == "answer15" || SceneManager.GetActiveScene().name == "answer16" || SceneManager.GetActiveScene().name == "answer18")
                {
                    Debug.Log("zweite if");
                    int score = PlayerPrefs.GetInt("Score");
                    score += 1;
                    PlayerPrefs.SetInt("Score", score);
                }
            }
        }

        if (PlayerPrefs.HasKey("Fake"))
        {
            int fake = PlayerPrefs.GetInt("Fake");
            if (fake ==1)
            {
                Debug.Log("erste if");
                if (SceneManager.GetActiveScene().name == "answer2" || SceneManager.GetActiveScene().name == "answer3" || SceneManager.GetActiveScene().name == "answer5" || SceneManager.GetActiveScene().name == "answer8" || SceneManager.GetActiveScene().name == "answer9" || SceneManager.GetActiveScene().name == "answer11" || SceneManager.GetActiveScene().name == "answer12" || SceneManager.GetActiveScene().name == "answer13" || SceneManager.GetActiveScene().name == "answer17")
                {
                    Debug.Log("zweite if");
                    int score = PlayerPrefs.GetInt("Score");
                    score += 1;
                    PlayerPrefs.SetInt("Score", score);
                }
            }
        }
    }

    
    void Update()
    {
        
    }
}
