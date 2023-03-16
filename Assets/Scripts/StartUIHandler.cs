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
    public GameObject textFieldObject;
    public TMP_Text textField;

    void Awake()
    {
        inputField = inputFieldObject.GetComponent<TMP_InputField>();
        textField = textFieldObject.GetComponent<TMP_Text>();

    }

    // Start is called before the first frame update
    void Start()
    {
        textField = textFieldObject.GetComponent<TMP_Text>();
        if (DataManager.Instance.Name != null)
        {
            textField.text = DataManager.Instance.Name;
        }
        else
        {

            textField.text = "HumanName";
        }
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
        DataManager.Instance.SaveName();
    }
}
