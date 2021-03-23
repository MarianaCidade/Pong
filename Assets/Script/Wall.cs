using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    ScoreKeeper scoreKeeper;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
         * Quando a bola bater, avisamos o ScoreKeeper
         * para aumentar pontuação
         */

        scoreKeeper.Goal();

    }
}
