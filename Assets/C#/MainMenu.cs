using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    // Fonction for quit the game
    void QuitGame()
    {
        Application.Quit();
    }
}
