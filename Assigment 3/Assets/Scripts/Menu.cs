using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SoundEffects.SelectSound = true;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        SoundEffects.SelectSound = true;
        Application.Quit();
    }

    public void Credits()
    {
        SoundEffects.SelectSound = true;
        SceneManager.LoadScene(5);
    }
}
