using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Localization/LocalString")]
public class LocalString : ScriptableObject {

    [SerializeField]
    SystemOptions MyOptions;
    [SerializeField]
    LocalStringWrapper English;
    [SerializeField]
    LocalStringWrapper PortugeseBrazilian;
    [SerializeField]
    LocalStringWrapper Spanish;
    List<LocalStringWrapper> myList;
    bool initialized = false;
    public string Content()
        {
        if (!initialized)
            {
            myList = new List<LocalStringWrapper> { English, PortugeseBrazilian, Spanish };
            initialized = true;
            }
        for (int i = 0; i < myList.Count; i++)
            {
            if (MyOptions.currentLang == myList[i].language)
                return myList[i].content;
            }
        return "Language not found.";
        }
    public void Subscribe(SystemOptions.LanguageChange method)
        {
        MyOptions.Subscribe(method);
        }
    public void Unsubscribe(SystemOptions.LanguageChange method)
        {
        MyOptions.Unsubscribe(method);
        }
    }
[System.Serializable]
public class LocalStringWrapper
    {
    public Language language;
    public string content;
    }
