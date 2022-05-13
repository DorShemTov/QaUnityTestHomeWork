using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public bool IsWinning = false;

    public bool CheckWinOrLose(int score)
    {
        
        if (score >= 5)
        {
            IsWinning = true;
        }
        else
        {
            IsWinning = false;
        }
        return IsWinning;
    }


}
