using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void LoadLevel(int sceneIndex)
    {
        GameManager.Instance.CurrentSceneIndex = sceneIndex;
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
        UIManager.Instance.ActivateScreen(1);
    }

    public void UnLoadLevel()
    {
        if(GameManager.Instance.CurrentSceneIndex != 0)
        {
            GameManager.Instance.IsTotalEventsComplete = false;
            SceneManager.UnloadSceneAsync(GameManager.Instance.CurrentSceneIndex);
            GameManager.Instance.CurrentSceneIndex = 0;
            UIManager.Instance.ActivateScreen(0);
        }
    }

    public void NextLevel()
    {
        SceneManager.UnloadSceneAsync(GameManager.Instance.CurrentSceneIndex);
        GameManager.Instance.CurrentSceneIndex += 1;
        SceneManager.LoadScene(GameManager.Instance.CurrentSceneIndex,LoadSceneMode.Additive);
        UIManager.Instance.ActivateScreen(1);
    }
}
