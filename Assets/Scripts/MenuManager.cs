using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public void PlayGame(string sceneName)
    {
        Debug.Log($"loaded MainGame");
        SceneManager.LoadScene("MainGame");
    }
}
