using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrintLog : MonoBehaviour
{
    public Button myButton; // 버튼을 연결할 변수

    void Start()
    {
        // 버튼이 연결되어 있다면 클릭 이벤트 추가
        if (myButton != null)
            myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("버튼이 클릭되었습니다!");
    }
}
