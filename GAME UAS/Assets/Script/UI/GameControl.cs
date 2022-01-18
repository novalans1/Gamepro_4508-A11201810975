using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject gameOverPanel;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Instantiate(gameOverPanel, parent:transform);
    }
}
