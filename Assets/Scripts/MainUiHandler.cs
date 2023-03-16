using UnityEngine;
using TMPro;
using System.Xml;

public class MainUiHandler : MonoBehaviour
{
    public TMP_Text nameText;
    public GameObject nameTextObject;

    void Start()
    {
       

        nameText = nameTextObject.GetComponent<TMP_Text>();
        

        if (DataManager.Instance.Name != null)
        {
            nameText.text = DataManager.Instance.Name;
        }
        else
        {
            
            nameText.text = "HumanName";
        }
    }
}

