using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLanguage : MonoBehaviour {

    public SystemOptions myOptions;
    public Language langToChange;

    public void Change()
        {
        myOptions.ChangeLanguage(langToChange);
        }
    }
