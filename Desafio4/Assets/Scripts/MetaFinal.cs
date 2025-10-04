using UnityEngine;

public class MetaFinal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("🎉🎉🎉🎉 Has completado el juego! 🎉🎉🎉🎉");
        }
    }
}
