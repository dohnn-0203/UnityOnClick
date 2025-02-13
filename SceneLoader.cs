using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // 씬 이름을 입력받는 UI InputField
    public Button loadSceneButton; // 씬을 로드하는 버튼

    void Start()
    {
        // 버튼 클릭 이벤트 연결
        if (loadSceneButton != null)
            loadSceneButton.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogWarning("씬 이름을 입력해주세요!");
            return;
        }

        // 씬이 빌드에 포함되어 있는지 확인
        if (IsSceneInBuild(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError($"'{sceneName}' 씬이 존재하지 않습니다. 씬 빌드 설정을 확인하세요.");
        }
    }

    bool IsSceneInBuild(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string name = System.IO.Path.GetFileNameWithoutExtension(path);
            if (name == sceneName) return true;
        }
        return false;
    }
}
