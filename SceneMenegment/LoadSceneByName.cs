using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{
    [SerializeField]string nextSceneName;

    public void LoadNextScene(string nextSceneName)
    {
        if(nextSceneName != null &&  SceneManager.GetSceneByName(nextSceneName)!= null) 
            SceneManager.LoadScene(nextSceneName);
        else Print.Log("Cant load scane!");
    }
    public void LoadNextScene()
    {
        if (nextSceneName != null && SceneManager.GetSceneByName(nextSceneName) != null)
            SceneManager.LoadScene(nextSceneName);
        else Print.Log("Cant load scane!");
    }     
}
