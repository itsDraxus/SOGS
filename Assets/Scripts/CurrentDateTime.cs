using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CurrentDateTime : MonoBehaviour
{
    public TMP_Text currentTime;

    // Update is called once per frame
    void Update()
    {
        currentTime.text = DateTime.Now.ToShortTimeString();
    }
}
