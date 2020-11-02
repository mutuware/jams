using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // dead
        SceneManager.LoadScene(0);
    }
}
