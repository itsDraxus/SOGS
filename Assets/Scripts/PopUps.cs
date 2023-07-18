using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUps : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private float timer = 0f;
    public float damageTimer;

    private Camera playerHandler;

    private void Awake()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            playerHealth = mainCamera.GetComponent<PlayerHealth>();
        }
        else
        {
            Debug.LogError("No main camera found in the scene!");
        }
    }

    private void Update()
    {
        if(timer <= damageTimer)
        {
            timer += Time.deltaTime;
        }
        else
        {
            playerHealth.Damage(1f);
            timer = 0f;
        }
    }
}
