using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public enum WallName {Left, Right }

    [SerializeField]
    Scorekeeper scoreKeeper;

    [SerializeField]
    Ball ball;

    [SerializeField]
    WallName wallName = WallName.Left;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* quando a bola bater avisamos o score keeper para aumentar pontuação */
        scoreKeeper.Goal(wallName);
        ball.Reset();
    }
}
