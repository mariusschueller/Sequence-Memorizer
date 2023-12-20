using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    private int suit;
    private int cardNum;

    private int guessSuit;
    private int guessNum;
    private bool guessedNum;
    private bool guessedSuit;
    private bool guessed;

    public GameObject spade;
    public GameObject club;
    public GameObject diamond;
    public GameObject heart;

    public GameObject setButton;
    public GameObject checkMark;
    public GameObject x;

    //public GameObject cardText;
    public Text cardNumText;

    public void createCard()
    {
        suit = Random.Range(1, 5);
        cardNum = Random.Range(1, 14);

        spade.SetActive(false);
        club.SetActive(false);
        diamond.SetActive(false);
        heart.SetActive(false);

        guessed = true; // so that you can't tap the cards

        if (suit == 1)
        {
            spade.SetActive(true);
            cardNumText.color = Color.black;
        }
           
       
        else if (suit == 2)
        {
            club.SetActive(true);
            cardNumText.color = Color.black;
        }
       
        else if (suit == 3)
        {
            diamond.SetActive(true);
            cardNumText.color = Color.red;
        }
            
        else if (suit == 4)
        {
            heart.SetActive(true);
            cardNumText.color = Color.red;
            suit = 0;
        }

        if (cardNum == 11)
            cardNumText.text = "J";
        else if (cardNum == 12)
            cardNumText.text = "Q";
        else if (cardNum == 13)
            cardNumText.text = "K";
        else if (cardNum == 1)
            cardNumText.text = "A";
        else
            cardNumText.text = cardNum.ToString();
    }

    public void disappear()
    {
        spade.SetActive(false);
        club.SetActive(false);
        diamond.SetActive(false);
        heart.SetActive(false);

        cardNumText.color = Color.black;

        cardNumText.text = "";
        guessSuit = 0;
        guessNum = 0;
        guessedNum = false;
        guessedSuit = false;
        guessed = false;
    }

    public void tap()
    {
        if (guessedNum == true && guessed == false)
        {
            guessSuit++;
            setButton.SetActive(true);
            guessedSuit = true;
            if (guessSuit == 1)
            {
                spade.SetActive(true);
                heart.SetActive(false);
                cardNumText.color = Color.black;
            }

            else if (guessSuit == 2)
            {
                club.SetActive(true);
                spade.SetActive(false);
                cardNumText.color = Color.black;
            }

            else if (guessSuit == 3)
            {
                diamond.SetActive(true);
                club.SetActive(false);
                cardNumText.color = Color.red;
            }

            else
            {
                heart.SetActive(true);
                diamond.SetActive(false);
                cardNumText.color = Color.red;
                guessSuit = 0;
            }
        } 

        else if (guessedNum == false && guessedNum == false && guessed == false)
        {
            setButton.SetActive(true);
            
            guessNum++;

            if (guessNum == 11)
                cardNumText.text = "J";
            else if (guessNum == 12)
                cardNumText.text = "Q";
            else if (guessNum == 13)
            {
                cardNumText.text = "K";
                guessNum = 0;
            }
            else if (guessNum == 1)
                cardNumText.text = "A";
            else
                cardNumText.text = guessNum.ToString();
        }
    }

    
    public void set()
    {
        if (guessedNum == false)
        {
            guessedNum = true;
            setButton.SetActive(false);
        }
            
        if (guessedNum == true && guessedSuit == true)
        {
            setButton.SetActive(false);
            guessed = true;
            //checkIfRight();
        }
            
    }

    public void checkIfRight()
    {
        setButton.SetActive(false);
        if (guessNum == cardNum && guessSuit == suit)
        {
            Debug.Log("right");
            checkMark.SetActive(true);
            x.SetActive(false);
        }

        else
        {
            Debug.Log("wrong");
            x.SetActive(true);
            checkMark.SetActive(false);
        }
            
    }
}