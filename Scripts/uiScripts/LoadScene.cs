using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //fun��o para ser chama em um bot�o
    public void LoadSceneFunction(string load)
    {
        SceneManager.LoadScene(load);
    }
}
