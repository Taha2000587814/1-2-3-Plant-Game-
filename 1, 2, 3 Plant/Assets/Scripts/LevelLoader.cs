using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;

    public void Start()
    {

    }


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadLevelWithDelay(sceneIndex, 5f));
    }

    IEnumerator LoadLevelWithDelay(int sceneIndex, float delay)
    {
        loadingScreen.SetActive(true);
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneIndex);
        loadingScreen.SetActive(false);
    }

}
