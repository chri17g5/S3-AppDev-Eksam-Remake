using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //---------------------------------------------------
    //  Script that keep track of UI elements
    //
    //  SetActive(bool) enabels or disabels an element
    //  
    //  Display and tabs:
    //      Display = Parent to tabs
    //      Tabs = children to Display
    //---------------------------------------------------

    [Header("Login/Register Display & Tabs")]
    public GameObject AuthDisplay;
    public GameObject LoginScreen;
    public GameObject RegisterScreen;

    [Header("MainCotent Display & Tabs")]
    public GameObject MainContentDisplay;

    //creation of UIManager instance
    public static UIManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroy object!");
            Destroy(this);
        }
    }

    #region AuthUI & its tabs
    public void ToRegFromLogin()
    {
        LoginScreen.SetActive(false);
        RegisterScreen.SetActive(true);
    }

    public void ToLoginFromReg()
    {
        RegisterScreen.SetActive(false);
        LoginScreen.SetActive(true);
    }

    public void ToMainFromLogin()
    {
        AuthDisplay.SetActive(false);
        MainContentDisplay.SetActive(true);
    }
    #endregion
}
