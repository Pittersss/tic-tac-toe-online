using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Quadrant[] quadrants;
    public bool SomeOneWon { get; private set; }
    public Symbol WinnersSymbol { get; private set; }

    public void VerifyWinner()
    {
        VerifyWonPossibility(0, 1, 3);
        VerifyWonPossibility(3, 1, 6);
        VerifyWonPossibility(6, 1, 9);

        VerifyWonPossibility(0, 4, 9);
        VerifyWonPossibility(2, 2, 7);

        VerifyWonPossibility(0, 3, 7);
        VerifyWonPossibility(1, 3, 8);
        VerifyWonPossibility(2, 3, 9);

    }

    private void VerifyWonPossibility(int startIndex, int jumpIndex, int limit)
    {
        int localIndex = startIndex;
        bool haveConflit = false;
        while (localIndex < limit)
        {
            if (quadrants[startIndex].Symbol != quadrants[localIndex].Symbol)
            {
                haveConflit = true;
                break;
            }
            localIndex += jumpIndex;
        }

        if (!haveConflit)
        {
            SomeOneWon = true;
            WinnersSymbol = quadrants[startIndex].Symbol;
        }
    }

}


