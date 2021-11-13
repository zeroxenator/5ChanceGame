using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessManager : MonoBehaviour
{
    // Pass all Guess Objects

    //Images of 1st Guess
    [SerializeField] private Image Guess11_Image;
    [SerializeField] private Image Guess12_Image;
    [SerializeField] private Image Guess13_Image;
    [SerializeField] private Image Guess14_Image;
    [SerializeField] private Image Guess15_Image;

    //Images of 2nd Guess
    [SerializeField] private Image Guess21_Image;
    [SerializeField] private Image Guess22_Image;
    [SerializeField] private Image Guess23_Image;
    [SerializeField] private Image Guess24_Image;
    [SerializeField] private Image Guess25_Image;

    //Images of 3rd Guess
    [SerializeField] private Image Guess31_Image;
    [SerializeField] private Image Guess32_Image;
    [SerializeField] private Image Guess33_Image;
    [SerializeField] private Image Guess34_Image;
    [SerializeField] private Image Guess35_Image;

    //Images of 4th Guess
    [SerializeField] private Image Guess41_Image;
    [SerializeField] private Image Guess42_Image;
    [SerializeField] private Image Guess43_Image;
    [SerializeField] private Image Guess44_Image;
    [SerializeField] private Image Guess45_Image;

    //Images of 5th Guess
    [SerializeField] private Image Guess51_Image;
    [SerializeField] private Image Guess52_Image;
    [SerializeField] private Image Guess53_Image;
    [SerializeField] private Image Guess54_Image;
    [SerializeField] private Image Guess55_Image;

    //Characters of 1st Guess
    [SerializeField] private Text Guess11_Text;
    [SerializeField] private Text Guess12_Text;
    [SerializeField] private Text Guess13_Text;
    [SerializeField] private Text Guess14_Text;
    [SerializeField] private Text Guess15_Text;

    //Characters of 2nd Guess
    [SerializeField] private Text Guess21_Text;
    [SerializeField] private Text Guess22_Text;
    [SerializeField] private Text Guess23_Text;
    [SerializeField] private Text Guess24_Text;
    [SerializeField] private Text Guess25_Text;

    //Characters of 3rd Guess
    [SerializeField] private Text Guess31_Text;
    [SerializeField] private Text Guess32_Text;
    [SerializeField] private Text Guess33_Text;
    [SerializeField] private Text Guess34_Text;
    [SerializeField] private Text Guess35_Text;

    //Characters of 4th Guess
    [SerializeField] private Text Guess41_Text;
    [SerializeField] private Text Guess42_Text;
    [SerializeField] private Text Guess43_Text;
    [SerializeField] private Text Guess44_Text;
    [SerializeField] private Text Guess45_Text;

    //Characters of 5th Guess
    [SerializeField] private Text Guess51_Text;
    [SerializeField] private Text Guess52_Text;
    [SerializeField] private Text Guess53_Text;
    [SerializeField] private Text Guess54_Text;
    [SerializeField] private Text Guess55_Text;

    [SerializeField] private Color32 squareColor;
    [SerializeField] private Color32 circleColor;

    public void RunGuess(int inGuessCounter, string inUserGuessWord, string inGameGuessWord)
    {
        // Show the guess word on screen
        UpdateDisplayText(inGuessCounter, inUserGuessWord);        

        // Show the image and clue on screen
        EnableDisplayImage(inGuessCounter);
        UpdateDisplayImage(inGuessCounter, inUserGuessWord, inGameGuessWord);        
    }

    public void ResetGuesses()
    {
        // Reset Text
        Guess11_Text.text = "";
        Guess12_Text.text = "";
        Guess13_Text.text = "";
        Guess14_Text.text = "";
        Guess15_Text.text = "";

        Guess21_Text.text = "";
        Guess22_Text.text = "";
        Guess23_Text.text = "";
        Guess24_Text.text = "";
        Guess25_Text.text = "";

        Guess31_Text.text = "";
        Guess32_Text.text = "";
        Guess33_Text.text = "";
        Guess34_Text.text = "";
        Guess35_Text.text = "";

        Guess41_Text.text = "";
        Guess42_Text.text = "";
        Guess43_Text.text = "";
        Guess44_Text.text = "";
        Guess45_Text.text = "";

        Guess51_Text.text = "";
        Guess52_Text.text = "";
        Guess53_Text.text = "";
        Guess54_Text.text = "";
        Guess55_Text.text = "";

        // Reset Image
        Guess11_Image.color = Color.white;
        Guess12_Image.color = Color.white;
        Guess13_Image.color = Color.white;
        Guess14_Image.color = Color.white;
        Guess15_Image.color = Color.white;
        Guess21_Image.color = Color.white;
        Guess22_Image.color = Color.white;
        Guess23_Image.color = Color.white;
        Guess24_Image.color = Color.white;
        Guess25_Image.color = Color.white;
        Guess31_Image.color = Color.white;
        Guess32_Image.color = Color.white;
        Guess33_Image.color = Color.white;
        Guess34_Image.color = Color.white;
        Guess35_Image.color = Color.white;
        Guess41_Image.color = Color.white;
        Guess42_Image.color = Color.white;
        Guess43_Image.color = Color.white;
        Guess44_Image.color = Color.white;
        Guess45_Image.color = Color.white;
        Guess51_Image.color = Color.white;
        Guess52_Image.color = Color.white;
        Guess53_Image.color = Color.white;
        Guess54_Image.color = Color.white;
        Guess55_Image.color = Color.white;

        // Inactive Image
        Guess11_Image.gameObject.SetActive(false);
        Guess12_Image.gameObject.SetActive(false);
        Guess13_Image.gameObject.SetActive(false);
        Guess14_Image.gameObject.SetActive(false);
        Guess15_Image.gameObject.SetActive(false);
        Guess21_Image.gameObject.SetActive(false);
        Guess22_Image.gameObject.SetActive(false);
        Guess23_Image.gameObject.SetActive(false);
        Guess24_Image.gameObject.SetActive(false);
        Guess25_Image.gameObject.SetActive(false);
        Guess31_Image.gameObject.SetActive(false);
        Guess32_Image.gameObject.SetActive(false);
        Guess33_Image.gameObject.SetActive(false);
        Guess34_Image.gameObject.SetActive(false);
        Guess35_Image.gameObject.SetActive(false);
        Guess41_Image.gameObject.SetActive(false);
        Guess42_Image.gameObject.SetActive(false);
        Guess43_Image.gameObject.SetActive(false);
        Guess44_Image.gameObject.SetActive(false);
        Guess45_Image.gameObject.SetActive(false);
        Guess51_Image.gameObject.SetActive(false);
        Guess52_Image.gameObject.SetActive(false);
        Guess53_Image.gameObject.SetActive(false);
        Guess54_Image.gameObject.SetActive(false);
        Guess55_Image.gameObject.SetActive(false);
    }

    private void UpdateDisplayText(int inGuessCounter, string inUserGuessWord)
    {
        switch (inGuessCounter)
        {
            case 1:
                Guess11_Text.text = inUserGuessWord[0].ToString();
                Guess12_Text.text = inUserGuessWord[1].ToString();
                Guess13_Text.text = inUserGuessWord[2].ToString();
                Guess14_Text.text = inUserGuessWord[3].ToString();
                Guess15_Text.text = inUserGuessWord[4].ToString();
                break;
            case 2:
                Guess21_Text.text = inUserGuessWord[0].ToString();
                Guess22_Text.text = inUserGuessWord[1].ToString();
                Guess23_Text.text = inUserGuessWord[2].ToString();
                Guess24_Text.text = inUserGuessWord[3].ToString();
                Guess25_Text.text = inUserGuessWord[4].ToString();
                break;
            case 3:
                Guess31_Text.text = inUserGuessWord[0].ToString();
                Guess32_Text.text = inUserGuessWord[1].ToString();
                Guess33_Text.text = inUserGuessWord[2].ToString();
                Guess34_Text.text = inUserGuessWord[3].ToString();
                Guess35_Text.text = inUserGuessWord[4].ToString();
                break;
            case 4:
                Guess41_Text.text = inUserGuessWord[0].ToString();
                Guess42_Text.text = inUserGuessWord[1].ToString();
                Guess43_Text.text = inUserGuessWord[2].ToString();
                Guess44_Text.text = inUserGuessWord[3].ToString();
                Guess45_Text.text = inUserGuessWord[4].ToString();
                break;
            case 5:
                Guess51_Text.text = inUserGuessWord[0].ToString();
                Guess52_Text.text = inUserGuessWord[1].ToString();
                Guess53_Text.text = inUserGuessWord[2].ToString();
                Guess54_Text.text = inUserGuessWord[3].ToString();
                Guess55_Text.text = inUserGuessWord[4].ToString();
                break;
            default:
                break;
        }
    }

    private void UpdateDisplayImage(int inGuessCounter, string inUserGuessWord, string inGameGuessWord)
    {
        // Check for correct letter wrong pos
        foreach (Char c in inGameGuessWord)
        {
            int idx = inUserGuessWord.IndexOf(c);

            // found
            if (idx != -1)
            {
                SetColorOfLetter(inGuessCounter, idx, circleColor);
            }
        }

        // Check for correct letter correct pos
        for (int idx = 0; idx < inUserGuessWord.Length; idx++)
        {
            if (inUserGuessWord[idx] == inGameGuessWord[idx])
            {
                SetColorOfLetter(inGuessCounter, idx, squareColor);
            }
        }
    }

    private void SetAnimationOfLetter()
    {
        Guess11_Image.transform.GetComponent<Animator>().SetTrigger("Start");
    }

    private void SetColorOfLetter(int userGuessCounter, int letterIndex, Color32 letterColor)
    {
        switch (userGuessCounter)
        {
            case 1:
                if (letterIndex == 0)
                {
                    Guess11_Image.color = letterColor;
                    SetAnimationOfLetter();
                }
                if (letterIndex == 1) Guess12_Image.color = letterColor;
                if (letterIndex == 2) Guess13_Image.color = letterColor;
                if (letterIndex == 3) Guess14_Image.color = letterColor;
                if (letterIndex == 4) Guess15_Image.color = letterColor;
                break;
            case 2:
                if (letterIndex == 0) Guess21_Image.color = letterColor;
                if (letterIndex == 1) Guess22_Image.color = letterColor;
                if (letterIndex == 2) Guess23_Image.color = letterColor;
                if (letterIndex == 3) Guess24_Image.color = letterColor;
                if (letterIndex == 4) Guess25_Image.color = letterColor;
                break;
            case 3:
                if (letterIndex == 0) Guess31_Image.color = letterColor;
                if (letterIndex == 1) Guess32_Image.color = letterColor;
                if (letterIndex == 2) Guess33_Image.color = letterColor;
                if (letterIndex == 3) Guess34_Image.color = letterColor;
                if (letterIndex == 4) Guess35_Image.color = letterColor;
                break;
            case 4:
                if (letterIndex == 0) Guess41_Image.color = letterColor;
                if (letterIndex == 1) Guess42_Image.color = letterColor;
                if (letterIndex == 2) Guess43_Image.color = letterColor;
                if (letterIndex == 3) Guess44_Image.color = letterColor;
                if (letterIndex == 4) Guess45_Image.color = letterColor;
                break;
            case 5:
                if (letterIndex == 0) Guess51_Image.color = letterColor;
                if (letterIndex == 1) Guess52_Image.color = letterColor;
                if (letterIndex == 2) Guess53_Image.color = letterColor;
                if (letterIndex == 3) Guess54_Image.color = letterColor;
                if (letterIndex == 4) Guess55_Image.color = letterColor;
                break;
            default:
                break;
        }
    }

    private void EnableDisplayImage(int inGuessCounter)
    {
        switch (inGuessCounter)
        {
            case 1:
                Guess11_Image.gameObject.SetActive(true);
                Guess12_Image.gameObject.SetActive(true);
                Guess13_Image.gameObject.SetActive(true);
                Guess14_Image.gameObject.SetActive(true);
                Guess15_Image.gameObject.SetActive(true);
                break;
            case 2:
                Guess21_Image.gameObject.SetActive(true);
                Guess22_Image.gameObject.SetActive(true);
                Guess23_Image.gameObject.SetActive(true);
                Guess24_Image.gameObject.SetActive(true);
                Guess25_Image.gameObject.SetActive(true);
                break;
            case 3:
                Guess31_Image.gameObject.SetActive(true);
                Guess32_Image.gameObject.SetActive(true);
                Guess33_Image.gameObject.SetActive(true);
                Guess34_Image.gameObject.SetActive(true);
                Guess35_Image.gameObject.SetActive(true);
                break;
            case 4:
                Guess41_Image.gameObject.SetActive(true);
                Guess42_Image.gameObject.SetActive(true);
                Guess43_Image.gameObject.SetActive(true);
                Guess44_Image.gameObject.SetActive(true);
                Guess45_Image.gameObject.SetActive(true);
                break;
            case 5:
                Guess51_Image.gameObject.SetActive(true);
                Guess52_Image.gameObject.SetActive(true);
                Guess53_Image.gameObject.SetActive(true);
                Guess54_Image.gameObject.SetActive(true);
                Guess55_Image.gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
}
