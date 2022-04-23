using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //função para ser chama em um botão
    public void LoadSceneFunction(string load)
    {
        SceneManager.LoadScene(load);
    }
}
