using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Health playerHealth;
    public Image[] heartImages;
    int health = 3;


    void Awake()
    {
        playerHealth = FindObjectOfType<Health>();
    }

    void Update()
    {
        if (!playerHealth) return;

        if (health != playerHealth.healthAmount) UpdateHealth();
    }

    void UpdateHealth()
    {
        health = playerHealth.healthAmount;

        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < health) heartImages[i].gameObject.SetActive(true);
            else heartImages[i].gameObject.SetActive(false);
        }
    }
}
