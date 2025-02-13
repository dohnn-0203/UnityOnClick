using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // �� �̸��� �Է¹޴� UI InputField
    public Button loadSceneButton; // ���� �ε��ϴ� ��ư

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ ����
        if (loadSceneButton != null)
            loadSceneButton.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogWarning("�� �̸��� �Է����ּ���!");
            return;
        }

        // ���� ���忡 ���ԵǾ� �ִ��� Ȯ��
        if (IsSceneInBuild(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError($"'{sceneName}' ���� �������� �ʽ��ϴ�. �� ���� ������ Ȯ���ϼ���.");
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
