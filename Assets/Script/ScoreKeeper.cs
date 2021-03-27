using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;

    [SerializeField]
    TextMeshProUGUI leftScoreTxt;

    [SerializeField]
    TextMeshProUGUI rightScoreTxt;

    public void Goal(Wall.WallName collision)
    {
        if(collision == Wall.WallName.Right)
        {
            leftScore = leftScore + 1;

        }else if (collision == Wall.WallName.Left)
        {
            rightScore = rightScore + 1;

        }

        leftScoreTxt.text = leftScore.ToString();
        rightScoreTxt.text = rightScore.ToString();

        Debug.Log(leftScore + " " + rightScore);
    }


}
