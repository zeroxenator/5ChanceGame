using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMechanics : MonoBehaviour
{    
    public TextAsset WordsListTextAsset;
    public TextAsset EasyWordsListTextAsset;
    public TextAsset DefinitionTextAsset;

    public Text UserChar1;
    public Text UserChar2;
    public Text UserChar3;
    public Text UserChar4;
    public Text UserChar5;

    [SerializeField] TMP_Text FirstLetterInPlay;
    [SerializeField] private ValidationManager ValidationPopup;
    [SerializeField] private GameOverManager GameOverPopup;

    [SerializeField] private GuessManager _guessManager;

    public Text GameMessages;

    private string[] _wordsList = { };
    private string[] _allWordsList = { };

    private IDictionary<string, string> _dictionary = new Dictionary<string, string>();

    private string _guessWordInPlay = "";
    private string _userWordInPlay = "";

    private string _devWordInPlay = "";

    private int _userLetterCounter = 0;

    private int _userGuessCounter = 1;

    public void OnUserKeyPressed(string inKey)
    {
        if (_userWordInPlay.Length >= 5)
        {
            return;
        }
        else
        {
            _userWordInPlay += inKey;
            switch (_userLetterCounter)
            {
                case 0:
                    UserChar1.text = inKey;
                    break;
                case 1:
                    UserChar2.text = inKey;
                    break;
                case 2:
                    UserChar3.text = inKey;
                    break;
                case 3:
                    UserChar4.text = inKey;
                    break;
                case 4:
                    UserChar5.text = inKey;
                    break;
                default:
                    break;
            }

            _userLetterCounter += 1;
            
        }
    }

    public void OnClearButtonPressed()
    {
        ResetUserTypedWord();
    }

    public void OnGuessButtonPressed()
    {
        CheckUserGuess();   
    }

    public void OnRetryButtonPressed()
    {
        NewGameSetup();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void NewGameSetup()
    {
        GetNewWordToGuess();
        ResetUserGuesses();
        ResetUserTypedWord();
    }

    private void GetNewWordToGuess()
    {
        int idx = UnityEngine.Random.Range(0, _wordsList.Length);
        _guessWordInPlay = _wordsList[idx];

        Debug.Log("Word in Play: " + _guessWordInPlay);

        FirstLetterInPlay.text = _guessWordInPlay[0].ToString().ToUpper();
    }

    private void ResetUserGuesses()
    {
        _userGuessCounter = 1;
        _guessManager.ResetGuesses();
        GameMessages.text = "";
    }

    private void ResetUserTypedWord()
    {
        _userWordInPlay = "";
        _devWordInPlay = "";
        _userLetterCounter = 0;

        UserChar1.text = "";
        UserChar2.text = "";
        UserChar3.text = "";
        UserChar4.text = "";
        UserChar5.text = "";

        GameMessages.text = "";
    }

    private void CheckGuessCounterAndClear()
    {
        if (_userGuessCounter > 5)
        {
            UserLostGameScreen();
        }
        else
        {
            ResetUserTypedWord();
        }
    }

    private bool ValidateUserWord()
    {
        // Check if user word starts with first letter
        // display error message and clear
        if (GameModeMechanics.ForceLetterCheck)
        {
            if (_userWordInPlay[0].ToString() != _guessWordInPlay[0].ToString())
            {
                DisplayValidationPopup("Word should start with " + _guessWordInPlay[0].ToString());
                ResetUserTypedWord();
                return false;
            }
        }

        //Check word length is 5
        if (_userWordInPlay.Length != 5)
        {
            DisplayValidationPopup("Word should contain 5 letters");
            ResetUserTypedWord();
            return false;
        }        

        if (!_allWordsList.Contains(_userWordInPlay))
        {
            DisplayValidationPopup("Only valid words allowed");
            ResetUserTypedWord();
            return false;
        }
        return true;
    }

    private void SetWordMeaning()
    {
        GameOverPopup.Word_TMP.text = _guessWordInPlay;
        if (_dictionary.ContainsKey(_guessWordInPlay))
        {
            GameOverPopup.WordMeaning_TMP.text = _dictionary[_guessWordInPlay];
        }        
    }

    private void UserWonGameScreen()
    {
        GameOverPopup.gameObject.SetActive(true);
        GameOverPopup.GameOverTitle_TMP.text = "You Guessed It!";
        SetWordMeaning();
    }

    private void UserLostGameScreen()
    {
        GameOverPopup.gameObject.SetActive(true);
        GameOverPopup.GameOverTitle_TMP.text = "You Lost!";
        SetWordMeaning();

    }

    private void CheckUserGuess()
    {
        
        if (!ValidateUserWord())
        {
            return;
        }        

        if (_userWordInPlay == _guessWordInPlay)
        {
            UserWonGameScreen();
            return;
        }

        // Call GuessManager here to display the words and fancy pink/green
        _guessManager.RunGuess(_userGuessCounter, _userWordInPlay, _guessWordInPlay);

        _userGuessCounter += 1;

        CheckGuessCounterAndClear();
    }    

    private void DisplayValidationPopup(string inText)
    {
        ValidationPopup.gameObject.SetActive(true);
        ValidationPopup.Validation_Text.text = inText;
    }

    private void HideValidationPopup()
    {
        ValidationPopup.gameObject.SetActive(false);
    }

    private void HideGameOverPopup()
    {
        GameOverPopup.gameObject.SetActive(false);
        NewGameSetup();
    }

    private void Awake()
    {
        GameOverPopup.gameObject.SetActive(false);
        ValidationPopup.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {        
        LoadWordsList();

        LoadWordsDefinition();

        NewGameSetup();
    }

    private string[] CleanWordsList(string[] inWordsList)
    {
        for (int i = 0; i < inWordsList.Length; i++)
        {
            inWordsList[i] = inWordsList[i].Trim();
        }

        return inWordsList;
    }

    private void LoadWordsDefinition()
    {
        string[] definitions = DefinitionTextAsset.text.Trim().Split('\n');

        for(int i = 0; i < definitions.Length; i++)
        {
            string[] item = definitions[i].Trim().Split('\t');
            _dictionary.Add(item[0], item[1]);
        }
    }

    private void LoadWordsList()
    {
        if (GameModeMechanics.GameModeType == GameModeMechanics.GameMode.Easy)
        {
            _wordsList = CleanWordsList(EasyWordsListTextAsset.text.Split('\n'));
        }
        else
        {
            _wordsList = CleanWordsList(WordsListTextAsset.text.Split('\n'));
        }       

        _allWordsList = CleanWordsList(WordsListTextAsset.text.Split('\n'));
    }    

    private void DoTheThing(string inKey)
    {
        if (_devWordInPlay.Length > 100)
        {
            _devWordInPlay = "";
        }
        _devWordInPlay += inKey;

        if (_devWordInPlay.Contains("konami"))
        {
            GameMessages.text = "Tsk tsk, the word was " + _guessWordInPlay + ". You suck!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (ValidationPopup.gameObject.activeSelf)
            {
                HideValidationPopup();
            }
            else if (GameOverPopup.gameObject.activeSelf)
            {
                HideGameOverPopup();
            }
            else 
            {
                OnGuessButtonPressed();
            }
            
        }
        else if (Input.GetKeyUp(KeyCode.Backspace))
        {
            //Clear last user typed char on display
            if (_userLetterCounter == 1) UserChar1.text = "";
            if (_userLetterCounter == 2) UserChar2.text = "";
            if (_userLetterCounter == 3) UserChar3.text = "";
            if (_userLetterCounter == 4) UserChar4.text = "";
            if (_userLetterCounter == 5) UserChar5.text = "";

            //Update user typed word and counter
            _userWordInPlay = _userWordInPlay.Remove(_userWordInPlay.Length - 1);
            _userLetterCounter -= 1;
        }
        else if (Input.anyKey && !Input.GetKey(KeyCode.Backspace) && !Input.GetKey(KeyCode.Return))
        {
            string inKey = Input.inputString;
            if(inKey.Length == 1)
            {
                OnUserKeyPressed(inKey);

                // dev secret
                DoTheThing(inKey);                
            }
        }        
    }
}
