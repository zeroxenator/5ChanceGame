using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using TMPro;

public class MainMenuMechanics : MonoBehaviour
{
    public TMP_Text GameModeText;

    private GameModeMechanics.GameMode _gameMode;
    
    public void OnPlayGameClicked()
    {
        GameModeMechanics.GameModeType = _gameMode;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnQuitGameClicked()
    {
        Application.Quit();
    }

    public void OnLeftClicked()
    {
        GameModeText.text = "Easy";
        _gameMode = GameModeMechanics.GameMode.Easy;
    }

    public void OnRightClicked()
    {
        GameModeText.text = "Hard";
        _gameMode = GameModeMechanics.GameMode.Hard;
    }

    public void OnToggleForceFirstLetter()
    {
        GameModeMechanics.ForceLetterCheck = !GameModeMechanics.ForceLetterCheck;
    }

    // Start is called before the first frame update
    void Start()
    {
        _gameMode = GameModeMechanics.GameMode.Easy;
        GameModeText.text = GameModeMechanics.GameModeType.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
