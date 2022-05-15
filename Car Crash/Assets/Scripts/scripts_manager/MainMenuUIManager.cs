using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace game_ideas
{
    public class MainMenuUIManager : MonoBehaviour
    {

        [Header("Navigation UI")]
        [SerializeField] private Button previous_btn;
        [SerializeField] private Button next_btn;

        [Header("Characters UI")]
        [SerializeField] private Text characterName_text;

        public void SetCharactersInfo(GameCharactersData gcd)
        {
            characterName_text.text = gcd._name;
        }

        public void DisplayCharacterSelectionButtons(int currentIndex, int arraySize)
        {
            // previous character button
            if (currentIndex <= 0)
                previous_btn.gameObject.SetActive(false);
            else
                previous_btn.gameObject.SetActive(true);

            // next character button
            if (currentIndex >= (arraySize - 1))
                next_btn.gameObject.SetActive(false);
            else
                next_btn.gameObject.SetActive(true);
        }

    }
}
