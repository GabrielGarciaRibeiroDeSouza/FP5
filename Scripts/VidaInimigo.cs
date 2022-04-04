using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public int maxVida = 100;
    public int vidaAtual;

    //usa o outro script "barra de vida"
    public BarraDeVida healthBar;

    public GameObject player;

    //variaveis do audio
    public AudioSource som;
    public AudioClip DeststroiAudio;

    
    void Start()
    {
        vidaAtual = maxVida;

        healthBar.SetMaxHealth(maxVida);
    }

    
    void Update()
    {

        if (vidaAtual <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            AudioSource.PlayClipAtPoint(DeststroiAudio, transform.position);
            //SceneManager.LoadScene("ForaDeCombate");

        }
    }
    public void TomarDano(int dano)
    {
        vidaAtual -= dano;
        healthBar.SetHealth(vidaAtual);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("water"))
        {

            vidaAtual = 0;
        }

        if (other.CompareTag("tiraHP"))
        {
            TomarDano(10);
            Debug.Log("entro na hp ");
            som.Play();

        }
    }
}
