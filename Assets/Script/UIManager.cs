using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject StartPnl;
    [SerializeField] GameObject SettingsPnl;
    [SerializeField] GameObject FinalPnl;
    [SerializeField] GameObject GGPnl;

    private void Start() 
    {
     Time.timeScale = 0.0f;
    }

    // TapToStart 
    public void TTP()
    {
        Time.timeScale = 1.0f;
        StartPnl.SetActive(false);
    }

    public void LevelUpBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestarLevelBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SettingsBtn()
    {
        SettingsPnl.SetActive(true);
    }

    public void BackToSettingsBtn()
    {
        SettingsPnl.SetActive(false);
    }
}
