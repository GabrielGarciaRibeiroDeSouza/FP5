using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideElements : MonoBehaviour
{
    
    // Adicione o script no botão que usa esse script
    

    public GameObject[] show;
    public GameObject[] hide;

    //mostra os elementos da ui que forem adicionado no array
   public void ShowElements()
    {
        for (int i = 0; i < show.Length; i++)
        {
            show[i].SetActive(true);
        }
    }public void HideElements()
    {
        for (int i = 0; i < show.Length; i++)
        {
            hide[i].SetActive(false);
        }
    }
}
