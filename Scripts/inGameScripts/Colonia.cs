using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonia : MonoBehaviour
{
    public BarraDeVida vidaMainTorre;
    private int healthTorreFinal = 100;

    GameManager GM;

    void Start()
    {
        GM = new GameManager();
        healthTorreFinal = 100;
        vidaMainTorre.SetMaxHealth(healthTorreFinal);
    }

    
    void Update()
    {
        
    }
    public void TomarDanoColonia(int qtdDano)
    {
        
        healthTorreFinal -= qtdDano;
        vidaMainTorre.SetHealth(healthTorreFinal);

        if (healthTorreFinal <= 0)
        {
            MorreuTorreP();
        }
    }
    void MorreuTorreP()
    {
        //nessa função pode adicionar recompesa de moedas posteriormente
        GM.GameOver();
        Destroy(gameObject);
    }
}
