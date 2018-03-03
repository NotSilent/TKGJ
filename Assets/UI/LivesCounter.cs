using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesCounter : MonoBehaviour
{
    [SerializeField]
    int lives;
    public int Lives
    {
        get { return lives; }
        private set { lives = value; }
    }

    public void LoseLive()
    {
        Lives--;
        if(lives <= 0)
        {
            GoToScoreScene();
        }
    }

    void GoToScoreScene()
    {
        SceneManager.LoadScene("End");
    }
}
