using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrintLog : MonoBehaviour
{
    public Button myButton; // ��ư�� ������ ����

    void Start()
    {
        // ��ư�� ����Ǿ� �ִٸ� Ŭ�� �̺�Ʈ �߰�
        if (myButton != null)
            myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("��ư�� Ŭ���Ǿ����ϴ�!");
    }
}
