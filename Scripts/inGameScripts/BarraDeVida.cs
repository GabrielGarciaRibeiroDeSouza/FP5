using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int _health)
    {
        slider.maxValue = _health;
        slider.value = _health;
    }

    public void SetHealth(int _Health)
    {
        slider.value = _Health;
    }
}
