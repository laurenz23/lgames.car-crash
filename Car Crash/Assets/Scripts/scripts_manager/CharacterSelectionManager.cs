using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class CharacterSelectionManager : MonoBehaviour
    {

        [SerializeField] private float rotationSpeed;
        [SerializeField] private GameObject[] characters;
        [SerializeField] private GameCharactersData[] gameCharactersData;

        [Header("Script Reference")]
        [SerializeField] private MainMenuUIManager mainMenuUIManager;

        private int currentCharacterIndex;
        private Transform currentSelectedCharacter;

        private void Start()
        {
            currentCharacterIndex = 0;
            currentSelectedCharacter = characters[currentCharacterIndex].transform;
            currentSelectedCharacter.gameObject.SetActive(true);

            mainMenuUIManager.SetCharactersInfo(gameCharactersData[currentCharacterIndex]);
            mainMenuUIManager.DisplayCharacterSelectionButtons(currentCharacterIndex, characters.Length);
        }

        private void Update()
        {
            currentSelectedCharacter.localEulerAngles = new Vector3(currentSelectedCharacter.localEulerAngles.x, currentSelectedCharacter.localEulerAngles.y + (rotationSpeed * Time.deltaTime), currentSelectedCharacter.localEulerAngles.z);
        }

        public void PrevCharacter()
        {
            if (currentCharacterIndex > 0)
            {
                currentSelectedCharacter.gameObject.SetActive(false);

                currentCharacterIndex--;
                currentSelectedCharacter = characters[currentCharacterIndex].transform;
                currentSelectedCharacter.gameObject.SetActive(true);

                mainMenuUIManager.SetCharactersInfo(gameCharactersData[currentCharacterIndex]);
            }

            mainMenuUIManager.DisplayCharacterSelectionButtons(currentCharacterIndex, characters.Length);
        }

        public void NextCharacter()
        {
            if (currentCharacterIndex < (characters.Length - 1))
            {
                currentSelectedCharacter.gameObject.SetActive(false);

                currentCharacterIndex++;
                currentSelectedCharacter = characters[currentCharacterIndex].transform;
                currentSelectedCharacter.gameObject.SetActive(true);

                mainMenuUIManager.SetCharactersInfo(gameCharactersData[currentCharacterIndex]);
            }

            mainMenuUIManager.DisplayCharacterSelectionButtons(currentCharacterIndex, characters.Length);
        }

    }
}
