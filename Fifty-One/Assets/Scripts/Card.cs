using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int Id;
    public string CardName;
    public int Value;
    public string Element;
    public Sprite Sprite;

    public Card() { }

    public Card(int id, int value, string element, Sprite sprite)
    {
        Id = id;
        CardName = value + element;
        Value = value;
        Element = element;
        Sprite = sprite;
    }

}
