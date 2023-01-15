using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel(int sceneIndex)
    {
        GameManager.Instance.CurrentSceneIndex = sceneIndex;
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
        
    }

    public void UnLoadLevel()
    {
        if(GameManager.Instance.CurrentSceneIndex != 0)
            SceneManager.UnloadSceneAsync(GameManager.Instance.CurrentSceneIndex);
    }
}
