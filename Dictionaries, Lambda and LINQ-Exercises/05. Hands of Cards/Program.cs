using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();
            bool canContinue = true;
            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    canContinue = false;
                    break;
                }
                string[] inputSplit = input.Split(new char[] { ':' });
                string name = inputSplit[0];
                List<string> cardsList = inputSplit[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                List<string> existingList = new List<string>();
                if (cards.TryGetValue(name, out existingList))
                {
                    for (int i = 0; i < cardsList.Count; i++)
                    {
                        if (!existingList.Contains(cardsList[i]))
                        {
                            existingList.Add(cardsList[i]);
                        }
                    }
                }
                else
                {
                    cards.Add(name, cardsList);
                } 
            }
            foreach (var item in cards)
            {
                int points = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    string currentCard = item.Value[i];
                    int multiplier = 1;
                    if (currentCard.EndsWith("S"))
                    {
                        multiplier = 4;
                    }
                    else    if(currentCard.EndsWith("H"))
                    {
                        multiplier = 3;
                    }
                    else if (currentCard.EndsWith("D"))
                    {
                        multiplier = 2;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                    string currentCardValue = currentCard.TrimEnd(currentCard[currentCard.Length - 1]).Trim();

                    int cardValue = 0;
                    try
                    {
                        cardValue = int.Parse(currentCardValue);
                    }
                    catch (Exception)
                    {
                        switch (currentCardValue)
                        {
                            case "J":
                                cardValue = 11;
                                break;
                            case "Q":
                                cardValue = 12;
                                break;
                            case "K":
                                cardValue = 13;
                                break;
                            case "A":
                                cardValue = 14;
                                break;
                            default:
                                break;
                        }
                    }
                    points += cardValue * multiplier;
                }
                Console.WriteLine($"{item.Key}: {points}");
            }
        }
    }
}
