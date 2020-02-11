using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    private HandUpdate playerHand;

    [SerializeField] Text infoText;
    [SerializeField] Text timerText;
    [SerializeField] Text scoreText;
    [SerializeField] Text signeText;

    private int botSigne;
    private string playerSigne;
    private int nManche = 0;

    private int scoreBot = 0;
    private int scorePlayer = 0;

    void Start()
    {        
        playerHand = FindObjectOfType<HandUpdate>();
        StartCoroutine(Game());
    }

    IEnumerator Game()
    {
        while(true)
        {
            infoText.text = "Manche" + nManche.ToString();
            
            yield return new WaitForSeconds(2);
            timerText.text = "3";
            yield return new WaitForSeconds(1);
            timerText.text = "2";            
            yield return new WaitForSeconds(1);
            timerText.text = "1";
            yield return new WaitForSeconds(1);
            timerText.text = "0";
            botSigne = Random.Range(0,3);
            playerSigne = playerHand.GetPlayerSigne();
            signeText.text = playerSigne;
            playerWin(playerSigne, botSigne);
            nManche++;
            yield return new WaitForSeconds(2);
            if(scoreBot >= 3 || scorePlayer >= 3){
                break;
            }            
        }
        DisplayWinner();

    }

    public int GetSigne()
    {
        return botSigne;
    }

    private void playerWin(string playersigne, int botSigne)
    {
        if(playersigne == "rock" && botSigne == 0 || playersigne == "paper" && botSigne == 1 || playersigne == "cisor" && botSigne == 2)
        {
            infoText.text = "Egalité";
        }
        else if (playersigne == "rock" && botSigne == 2 || playersigne == "paper" && botSigne == 0 || playersigne == "cisor" && botSigne == 1)
        {
            infoText.text = "Victoire";
            scorePlayer++;
        }
        else if (playersigne == "rock" && botSigne == 1 || playersigne == "paper" && botSigne == 2 || playersigne == "cisor" && botSigne == 0)
        {
            infoText.text = "Défaite";
            scoreBot++;
        }
        scoreText.text = scorePlayer.ToString() + " / " + scoreBot.ToString();
    }

    private void DisplayWinner()
    {
        if(scorePlayer >= 3){
            infoText.text = "Vous avez gagné";
        }
        else{
            infoText.text = "Vous avez perdu";
        }
    }
    
}
