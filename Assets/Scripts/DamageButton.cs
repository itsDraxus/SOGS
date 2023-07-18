using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public GameObject healthController;

    private void Awake()
    {
        playerHealth = healthController.GetComponent<PlayerHealth>();
    }

    public void OnButtonPress()
    {
        playerHealth.Damage(1f);
    }
}
