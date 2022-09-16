using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManagement : MonoBehaviour
{
    private readonly System.Random _randomNumberGenerator = new System.Random();
    private List<string> _deck = new List<string>();

    public GameObject Area;
    public Image Card;

    // Start is called before the first frame update
    void Start()
    {
        //PopulateDeck();
        //ShuffleDeck();

        //// create card instances
        //for (int i = 0; i < _deck.Count; i++)
        //{
        //    Image card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
        //    card.transform.SetParent(Area.transform, false);
        //}        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PopulateDeck()
    {
        var elements = new List<string>()
        {
            "A", "E", "F", "Τ", "W"
        };

        for (int i = 1; i <= 5; i++)
        {
            string element = elements[_randomNumberGenerator.Next(0, elements.Count)];
            _deck.Add(i + element);
        }

        Debug.Log($"Deck initialized with cards: {string.Join(",", _deck)}");
    }

    void ShuffleDeck()
    {
        var tempDeck = new List<string>(_deck);
        int iterations = _deck.Count;
        _deck.Clear();

        for (int i = 0; i < iterations; i++)
        {
            int position = _randomNumberGenerator.Next(0, tempDeck.Count);
            _deck.Add(tempDeck[position]);
            tempDeck.RemoveAt(position);
        }

        Debug.Log($"Deck shuffled with cards: {string.Join(",", _deck)}");
    }
}
