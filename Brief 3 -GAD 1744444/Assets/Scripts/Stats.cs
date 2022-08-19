using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    public static Stats _instance;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI textComponent1;
    public TextMeshProUGUI textComponent2;
    public TextMeshProUGUI textComponent3;
    public TextMeshProUGUI textComponent4;
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void SetAndShowName(string message, string message1, string message2, string message3, string message4)
    {
        gameObject.SetActive(true);
        textComponent.text = message;
        textComponent1.text = message1;
        textComponent2.text = message2;
        textComponent3.text = message3;
        textComponent4.text = message4;
    }

    public void HideStats()
    {
        gameObject.SetActive(false);
        textComponent1.text = string.Empty;
        textComponent2.text = string.Empty;
        textComponent3.text= string.Empty;
        textComponent4.text= string.Empty;
    }
}
