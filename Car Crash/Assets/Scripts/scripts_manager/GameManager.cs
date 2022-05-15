using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class GameManager : MonoBehaviour
    {

        private static GameManager instance;

        public static GameManager GetInstance()
        {
            return instance;
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void GameStart()
        { 
        
        }

        public void GameContinue()
        {
            Time.timeScale = 1f;
        }

        public void GamePause()
        {
            Time.timeScale = 0f;
        }

        public void GameOver()
        {
            Debug.Log("Game Over");
        }

    }
}
