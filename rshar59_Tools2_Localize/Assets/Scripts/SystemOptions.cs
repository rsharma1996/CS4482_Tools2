using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Localization/SystemOptions")]
public class SystemOptions : ScriptableObject {

    public Language currentLang;
    public delegate void LanguageChange();
    public event LanguageChange OnLanguageChange;
    public void Subscribe(LanguageChange lang)
        {
        OnLanguageChange += lang;
        }
    public void Unsubscribe(LanguageChange lang)
        {
        OnLanguageChange -= lang;
        }
    public void ChangeLanguage(Language lang)
        {
        currentLang = lang;
        OnLanguageChange();
        }

    }
