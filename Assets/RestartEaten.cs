// Restart.cs - Restarts the game when the player reaches the finish
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartEaten : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}