using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play() 
    {
        SceneManager.LoadScene("Main1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
