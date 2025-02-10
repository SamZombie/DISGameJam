using UnityEngine;
using UnityEngine.SceneManagement;

public class Flower : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bug")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
