using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace game_ideas
{
    public class DataManager : MonoBehaviour
    {

        private static DataManager instance;

        public static DataManager GetInstance()
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

        [HideInInspector] public GameSettingsData gameSettingsData;
        [HideInInspector] public GameCharacterSelectedData gameCharacterSelectedData;
        [HideInInspector] public ProfilePlayerData profilePlayerData;
        [HideInInspector] public ProfileScoreData profileScoreData;
        [HideInInspector] public ProfileTokensData profileTokensData;

        private string fileExtension = ".json";
        private string gameSettingsFileName = "GameSettigsData";
        private string gameCharacterSelectedFileName = "GameCharacterSelectedData";
        private string profilePlayerFileName = "ProfilePlayerData";
        private string profileScoreFileName = "ProfileScoreData";
        private string profileTokensFileName = "ProfileTokensData";

        private void Start()
        {
            // LOAD DATA ------------------------------------------------
            gameSettingsData = LoadGameSettingsData();
            gameCharacterSelectedData = LoadGameCharacterSelectedData();
            profilePlayerData = LoadProfilePlayerData();
            profileScoreData = LoadProfileScoreData();
            profileTokensData = LoadProfileTokensData();
            // END LOAD DATA --------------------------------------------
        }

        public void SaveGameSettingsData(GameSettingsData gsd)
        {
            SaveData(gameSettingsFileName, gsd);
        }
        private GameSettingsData LoadGameSettingsData()
        {
            GameSettingsData gsd = new GameSettingsData();
            if (!LoadData(gameSettingsFileName, gsd))
            {
                gsd.disabledMusic = false;
                gsd.disabledSoundFx = false;
                SaveGameSettingsData(gsd);
            }

            return gsd;
        }

        public void SaveCharacterSelected(GameCharacterSelectedData gcsd)
        {
            SaveData(gameCharacterSelectedFileName, gcsd);
        }

        private GameCharacterSelectedData LoadGameCharacterSelectedData()
        {
            GameCharacterSelectedData gcsd = new GameCharacterSelectedData();
            if (!LoadData(gameCharacterSelectedFileName, gcsd))
            {
                gcsd.currentSelectedIndex = 0;
                SaveCharacterSelected(gcsd);
            }

            return gcsd;
        }

        public void SaveProfilePlayerData(ProfilePlayerData ppd)
        {
            SaveData(profilePlayerFileName, ppd);
        }

        private ProfilePlayerData LoadProfilePlayerData()
        {
            ProfilePlayerData ppd = new ProfilePlayerData();
            if (!LoadData(profilePlayerFileName, ppd))
            {
                ppd.name = "AI";
                ppd.level = 0;
                ppd.stageLevel = 0;
                SaveProfilePlayerData(ppd);
            }

            return ppd;
        }

        public void SaveProfileScoreData(ProfileScoreData psd)
        {
            SaveData(profileScoreFileName, psd);
        }

        private ProfileScoreData LoadProfileScoreData()
        {
            ProfileScoreData psd = new ProfileScoreData();
            if (!LoadData(profileScoreFileName, psd))
            {
                psd.score = 0;
                SaveProfileScoreData(psd);
            }

            return psd;
        }

        public void SaveProfileTokensData(ProfileTokensData ptd)
        {
            SaveData(profileTokensFileName, ptd);
        }

        private ProfileTokensData LoadProfileTokensData()
        {
            ProfileTokensData ptd = new ProfileTokensData();
            if (!LoadData(profileTokensFileName, ptd))
            {
                ptd.tokens = 0;
                SaveProfileTokensData(ptd);
            }

            return ptd;
        }

        private void SaveData(string fileName, object objectData)
        {
            string destination = Application.persistentDataPath + "/" + fileName + fileExtension;
            string json = JsonUtility.ToJson(objectData);
            File.WriteAllText(destination, json);

            Debug.Log(fileName + " Data File Save: " + destination);
        }

        private bool LoadData(string fileName, object objectData)
        {
            string destination = Application.persistentDataPath + "/" + fileName + fileExtension;

            if (File.Exists(destination))
            {
                string json = File.ReadAllText(destination);
                JsonUtility.FromJsonOverwrite(json, objectData);
                return true;
            }

            Debug.Log(fileName + " Data File does not exist: " + destination);

            return false;
        }

    }
}
