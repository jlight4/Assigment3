using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        SoundEffects.SelectSound = true;

        zCubeMovement.noCollision = false;
        CubeMovementX.noCollision = false;

        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            zCubeMovement.noCollision = true;
            CubeMovementX.noCollision = true;
            Time.timeScale = 1f;
        }
    }

    public void Restart()
    {
        SoundEffects.SelectSound = true;
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SoundEffects.SelectSound = true;
        SceneManager.LoadScene(0);
    }
}
