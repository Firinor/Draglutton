using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace FirMath
{
    public static class GameMath
    {
        public static int[] AFewCardsFromTheDeck(int NumberOfCardsDrawn, int DeckLength, bool WithoutDuplicates = true)
        {
            if (NumberOfCardsDrawn <= 0 || DeckLength <= 0)
            {
                return null;
            }

            if (NumberOfCardsDrawn >= DeckLength)
            {
                return Full(DeckLength);
            }

            return RandomCards(NumberOfCardsDrawn, DeckLength, WithoutDuplicates);
        }
        private static int[] RandomCards(int NumberOfCardsDrawn, int DeckLength, bool WithoutDuplicates)
        {
            int[] result = new int[NumberOfCardsDrawn];
            while (NumberOfCardsDrawn > 0)
            {
                result[NumberOfCardsDrawn - 1] = Random.Range(0, DeckLength);
                NumberOfCardsDrawn--;
            }
            if (WithoutDuplicates)
            {
                RemoveDuplicate(result);
            }
            return result;
        }
        private static void RemoveDuplicate(int[] result)
        {
            List<int> check = new List<int>();
            int resultLength = result.Length;
            for (int i = 0; i < resultLength; i++)
            {
                while (check.Contains(result[i]))
                {
                    result[i]++;
                    if(result[i] >= resultLength)
                    {
                        result[i] = 0;
                    }
                }
                check.Add(result[i]);
            }
        }
        private static int[] Full(int i)
        {
            int[] result = new int[i];
            while (i > 0)
            {
                result[i] = i;
                i--;
            }
            return result;
        }
    }
}