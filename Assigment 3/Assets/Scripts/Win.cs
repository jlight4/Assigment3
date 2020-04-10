using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SoundEffects.WinSound = true;
        GameManager.LevelWon = true;  
    }
}
