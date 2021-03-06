using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scorekeeper : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;

    [SerializeField]
    TextMeshProUGUI leftScoreTXT;

    [SerializeField]
    TextMeshProUGUI rightScoreTXT;

    public void Goal(Wall.WallName parede) {
        if (parede == Wall.WallName.Right)
        {
            leftScore += 1;
            leftScoreTXT.text = leftScore.ToString();
        }
        else if (parede == Wall.WallName.Left) {
            rightScore += 1;
            rightScoreTXT.text = rightScore.ToString();
        }
        
    }
}
