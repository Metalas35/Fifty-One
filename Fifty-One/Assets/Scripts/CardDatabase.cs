using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();

    private void Awake()
    {
        var elements = new List<string>()
        {
            "A", "E", "F", "Τ", "W"
        };

        int id = 0;
        foreach (string element in elements)
        {
            for (int i = 1; i <= 5; i++)
            {
                string spriteName = i + element;
                Cards.Add(new Card(id, i, element, Resources.Load<Sprite>("spriteName")));
                id++;
            }
        }

        Debug.Log($"Created deck of cards with {Cards.Count} elements");
    }
}
