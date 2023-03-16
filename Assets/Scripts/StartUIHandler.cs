using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

[DefaultExecutionOrder(1000)]
public class StartUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject inputFieldObject;

    void Awake()
    {
        inputField = inputFieldObject.GetComponent<TMP_InputField>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }
    public void StoreInputValue()
    {
        string inputValue = inputField.text;
        DataManager.Instance.Name = inputValue;
    }
}
