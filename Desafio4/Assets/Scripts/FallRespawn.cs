using UnityEngine;
using UnityEngine.SceneManagement;

public class FallRespawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reinicia la escena actual al tocar el cubo
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
