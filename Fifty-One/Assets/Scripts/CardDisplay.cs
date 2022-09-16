using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour
{
    public List<Card> DisplayCards = new List<Card>();
    public int DisplayId;

    //public Card Card;
    public int Id;
    public string CardName;
    public Sprite CardSprite;

    public Text Text;
    public Image CardImage;

    private void Start()
    {
        DisplayCards[0] = CardDatabase.Cards[DisplayId];
        Id = DisplayCards[0].Id;
        CardName = DisplayCards[0].CardName;
        CardSprite = DisplayCards[0].Sprite;

        Text.text = CardName;
        CardImage.sprite = CardSprite;
    }

    //private void Awake()
    //{
    //    DisplayCards[0] = CardDatabase.Cards[DisplayId];
    //}

    private void Update()
    {
        Text.text = DisplayCards[0].CardName;
        //Id = DisplayCards[0].Id;
        //Text.text = CardName;
    }
}
