using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public GameObject playButton; public GameObject playAgainButton;
    public GameObject guessButton;
    public GameObject cards;
    public GameObject fullCards;
    public GameObject check;
    public GameObject selectAmount;
    private bool number;

    public GameObject rightWrong;
    public GameObject extraRightWrong;

    void Start()
    {
        number = false;
        guess();
        check.SetActive(false);
        fullCards.SetActive(false);
        cards.SetActive(false);
        playButton.SetActive(true);
    }

    public void playPressed()
    {
        playButton.SetActive(false);
        selectAmount.SetActive(true);
        cards.SetActive(false);
        fullCards.SetActive(false);
        guessButton.SetActive(false);
        check.SetActive(false);
    }

    public void fourCards()
    {
        number = false;
        selectAmount.SetActive(false);
        cards.SetActive(true);
        guessButton.SetActive(true);
        extraRightWrong.SetActive(false);
    }

    public void sixCards()
    {
        number = true;
        selectAmount.SetActive(false);
        cards.SetActive(true);
        fullCards.SetActive(true);
        guessButton.SetActive(true);
        extraRightWrong.SetActive(true);
        //cards
    }

    public void guess()
    {
        guessButton.SetActive(false);
        //cards.SetActive(false);
        //fullCards.SetActive(false);
        check.SetActive(true);
        selectAmount.SetActive(false);
    }

    public void showCards()
    {
        rightWrong.SetActive(true);
        guessButton.SetActive(true);
        playAgainButton.SetActive(true);
        cards.SetActive(true);
        if (number == true)
            fullCards.SetActive(true);
        check.SetActive(false);
    }

    public void playAgain()
    {
        playAgainButton.SetActive(false);
        selectAmount.SetActive(true);
        cards.SetActive(false);
        fullCards.SetActive(false);
        guessButton.SetActive(false);
        check.SetActive(false);
        rightWrong.SetActive(false);
    }


}
