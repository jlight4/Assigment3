using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool LevelWon;

    // Start is called before the first frame update
    void Start()
    {
        LevelWon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelWon)
            NextLevel();
    }

    void NextLevel()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Menu()
    {
        SoundEffects.SelectSound = true;
        SceneManager.LoadScene(0);
    }
}
