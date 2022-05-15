using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace game_ideas
{
    public class InGameUIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI highestScore_tmp;
        [SerializeField] private TextMeshProUGUI currentScore_tmp;
        [SerializeField] private Button pause_btn;
        [SerializeField] private Toggle soundFx_toggle;
        [SerializeField] private Toggle music_toggle;
        [SerializeField] private GameObject pause_panel;

        private GameManager gameManager;

        private void Start()
        {
            gameManager = GameManager.GetInstance();

            OnGameStart();
        }

        public void OnGameStart()
        {
            gameManager.GameStart();

            highestScore_tmp.text = "Highest Score: 10000";
            SetCurrentScore(1000);

            pause_btn.gameObject.SetActive(true);
            pause_panel.SetActive(false);
        }

        public void OnGamePause()
        {
            gameManager.GamePause();

            pause_panel.SetActive(true);
            pause_btn.gameObject.SetActive(false);
        }

        public void OnGameContinue()
        {
            gameManager.GameContinue();

            pause_panel.SetActive(false);
            pause_btn.gameObject.SetActive(true);
        }

        public void OnSoundFX()
        {
            if (soundFx_toggle.isOn)
            {
                Debug.Log("Sound FX is Off");
                return;
            }

            Debug.Log("Sound FX is On");
        }

        public void OnMusic()
        {
            if (music_toggle.isOn)
            {
                Debug.Log("Music is off");
                return;
            }

            Debug.Log("Music is On");
        }

        public void OnMainMenu()
        {
            Debug.Log("Main Menu");
        }

        public void SetCurrentScore(int value)
        {
            currentScore_tmp.text = "Current Score: " + value.ToString();
        }

    }
}
