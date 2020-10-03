﻿using UnityEngine;

namespace NexoBinder.Samples.ScoreSample
{
    public class PlayState : MonoBehaviour
    {
        private const int SCORE_INCREMENT = 10;
        public ScoreView scoreView;

        private int score = 0;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                score += SCORE_INCREMENT;
                scoreView.score.Value = score;
            }
        }
    }
}