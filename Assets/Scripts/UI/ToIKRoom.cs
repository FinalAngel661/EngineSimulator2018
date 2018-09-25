using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToIKRoom : MonoBehaviour
{
    public Button IKButton;

    void Start()
    {
        Button btn = IKButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("IKInteractionBooth", LoadSceneMode.Single);
    }
}
