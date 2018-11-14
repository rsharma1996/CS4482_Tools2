using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[ExecuteInEditMode]
public class MyLocalString : MonoBehaviour {

    TextMeshProUGUI myText;
    public LocalString mystring;

    void Start()
        {
        myText = GetComponent<TextMeshProUGUI>();
        SetText();
        }

    void SetText()
        {
        myText.text = mystring.Content();
        }
    void getText()
        {
            
        }
    void OnEnable() { mystring.Subscribe(SetText); }
    void OnDisable() { mystring.Unsubscribe(SetText); }
    }
