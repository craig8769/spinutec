﻿using System.Collections.Generic;

namespace BluffinMuffin.HandEvaluator.Selectors
{
    public abstract class AbstractCardsSelector
    {
        public abstract IEnumerable<IEnumerable<PlayingCard>> SelectCards(IEnumerable<string> playerCards, IEnumerable<string> communityCards, EvaluationParams parms);
    }
}
