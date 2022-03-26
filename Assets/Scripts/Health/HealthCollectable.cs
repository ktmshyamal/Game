
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    [SerializeField] private float healthValue;
    [SerializeField] private AudioClip healthCollectorsound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlaySound(healthCollectorsound);
            collision.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false); 

        }
    }
}
