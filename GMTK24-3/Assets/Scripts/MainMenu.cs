using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        // Reemplaza "NombreDeLaEscenaDelJuego" con el nombre de la escena de tu juego
        SceneManager.LoadScene("Level1");
    }

    public void LoadCredits()
    {
        // Reemplaza "NombreDeLaEscenaDeCreditos" con el nombre de la escena de los créditos
        SceneManager.LoadScene("NombreDeLaEscenaDeCreditos");
    }

    public void BackMenu()
    {
        // Reemplaza "NombreDeLaEscenaDeCreditos" con el nombre de la escena de los créditos
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
