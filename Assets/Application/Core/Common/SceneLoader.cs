using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel(int sceneIndex)
    {
        GameManager.Instance.CurrentSceneIndex = sceneIndex;
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
        UIManager.Instance.ActivateScreen("EXIT");
    }

    public void UnLoadLevel()
    {
        if(GameManager.Instance.CurrentSceneIndex != 0)
        {
            UIManager.Instance.ActivateScreen("");
            GameManager.Instance.IsTotalEventsComplete = false;
            SceneManager.UnloadSceneAsync(GameManager.Instance.CurrentSceneIndex);
            GameManager.Instance.CurrentSceneIndex = 0;
            UIManager.Instance.ActivateScreen("LevelHolder");
        }
    }

    public void NextLevel()
    {
        UIManager.Instance.ActivateScreen("");
        SceneManager.UnloadSceneAsync(GameManager.Instance.CurrentSceneIndex);
        GameManager.Instance.CurrentSceneIndex += 1;
        SceneManager.LoadScene(GameManager.Instance.CurrentSceneIndex,LoadSceneMode.Additive);
        UIManager.Instance.ActivateScreen("EXIT");
    }

    public void RestartLevel()
    {
        UIManager.Instance.ActivateScreen("");
        SceneManager.UnloadSceneAsync(GameManager.Instance.CurrentSceneIndex);
        SceneManager.LoadScene(GameManager.Instance.CurrentSceneIndex, LoadSceneMode.Additive);
        UIManager.Instance.ActivateScreen("EXIT");
    }
}
