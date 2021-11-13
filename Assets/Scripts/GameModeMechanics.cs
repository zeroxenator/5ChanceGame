using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeMechanics : MonoBehaviour
{
    public enum GameMode
    {
        Easy,
        Hard
    }

    public static GameMode GameModeType = GameMode.Easy;

    public static bool ForceLetterCheck = true;

}
