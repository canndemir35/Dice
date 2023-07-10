using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    private int firstDice = 0;
    private int secondDice = 0;
    private int diceCount = 0;
    public List<Sprite> DiceImages = new List<Sprite>();
    public Image firstDiceImage;
    public Image secondDiceImage;
    public Animation firstDiceAnimation;
    public Animation secondDiceAnimation;
    public Button SingleButton;
    public Button DoubleButton;

    void Start()
    {
        firstDiceImage.sprite = DiceImages[0];
        secondDiceImage.sprite = DiceImages[2];
        diceCount = 0;
    }

    public void SingleDice()
    {
        diceCount++;
        
        if (diceCount % 2 == 0)
        {
            SecondDice();
        }
        else
        {
            FirstDice();
        }
    }
    
    public void DoubleDice()
    {
        FirstDice();
        SecondDice();
    }

    public void FirstDice()
    {
        StartCoroutine(FirstDiceNumaretor());
    }

    public void SecondDice()
    {
        StartCoroutine(SecondDiceNumerator());
    }
    
    public IEnumerator FirstDiceNumaretor()
    {
        SingleButton.interactable = false;
        DoubleButton.interactable = false;
        for (int i = 0; i < DiceImages.Count; i++)
        {
            firstDice = Random.Range(0, DiceImages.Count);
            firstDiceImage.sprite = DiceImages[firstDice];
            yield return new WaitForSeconds(0.2f);
        }
        
        SingleButton.interactable = true;
        DoubleButton.interactable = true;
        // firstDice = Random.Range(0, DiceImages.Count);
        // firstDiceImage.sprite = DiceImages[firstDice];
    }

    public IEnumerator SecondDiceNumerator()
    {
        SingleButton.interactable = false;
        DoubleButton.interactable = false;
        for (int i = 0; i < DiceImages.Count; i++)
        {
            secondDice = Random.Range(0, DiceImages.Count);
            secondDiceImage.sprite = DiceImages[secondDice];
            yield return new WaitForSeconds(0.2f);
        }
        
        SingleButton.interactable = true;
        DoubleButton.interactable = true;
        // secondDice = Random.Range(0, DiceImages.Count);
        // secondDiceImage.sprite = DiceImages[secondDice];
    }

}
