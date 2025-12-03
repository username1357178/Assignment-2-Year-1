using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTile : MonoBehaviour
{
    private Rigidbody2D body;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Health>().TakeDamage(999);
        }
    }
}