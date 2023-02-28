using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour

{
    float timer = 60f;
    [SerializeField] private TMP_Text cronometro;



    
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            timer = 60;
        }
        cronometro.text = " Tiempo Restante " + timer.ToString("f0");

    }

}
