using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //Slider = variable is in the form of a slider component
    Slider healthBar;

    //Player health information
    PlayerHealth player;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();

        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentHealth = player.GetHealth();
        float maxHealth = player.startingHealth;

        healthBar.value = currentHealth / maxHealth;
    }
}
