using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public Text uScore;
    public Text hScore;

    void Start() 
    {
        int HighScore = PlayerPrefs.GetInt("High Score", 0);
        int YourPoint = FindObjectOfType<Point>().point;

        if (YourPoint > HighScore)
        {
            PlayerPrefs.SetInt("High Score", YourPoint);
        }

        uScore.text = YourPoint.ToString();
        hScore.text = PlayerPrefs.GetInt("High Score", 0).ToString();

        FindObjectOfType<GameControl>().enabled = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
