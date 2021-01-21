using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saver : MonoBehaviour
{
    public GameObject[] Settings_Buttons;
    public int GetShiftScore(int LevelNum)
    {
        switch (LevelNum) 
        { 
            case 1:
                return PlayerPrefs.GetInt("ShiftScore1");

            case 2:
                return PlayerPrefs.GetInt("ShiftScore2");

            case 3:
                return PlayerPrefs.GetInt("ShiftScore3");

            case 4:
                return PlayerPrefs.GetInt("ShiftScore4");

            case 5:
                return PlayerPrefs.GetInt("ShiftScore5");

            case 6:
                return PlayerPrefs.GetInt("ShiftScore6");

            case 7:
                return PlayerPrefs.GetInt("ShiftScore7");

            case 8:
                return PlayerPrefs.GetInt("ShiftScore8");

            case 9:
                return PlayerPrefs.GetInt("ShiftScore9");

            case 10:
                return PlayerPrefs.GetInt("ShiftScore10");

            case 13:
                return PlayerPrefs.GetInt("ShiftScore13");

            case 14:
                return PlayerPrefs.GetInt("ShiftScore14");

            case 15:
                return PlayerPrefs.GetInt("ShiftScore15");

            case 16:
                return PlayerPrefs.GetInt("ShiftScore16");

            case 17:
                return PlayerPrefs.GetInt("ShiftScore17");

            case 18:
                return PlayerPrefs.GetInt("ShiftScore18");

            case 19:
                return PlayerPrefs.GetInt("ShiftScore19");

            case 20:
                return PlayerPrefs.GetInt("ShiftScore20");

            case 21:
                return PlayerPrefs.GetInt("ShiftScore21");

            case 22:
                return PlayerPrefs.GetInt("ShiftScore22");
        }
        return 0;
    }

    public void SetShiftScore(int LevelNum, int Score)
    {
        switch (LevelNum)
        {
            case 1:
                PlayerPrefs.SetInt("ShiftScore1", Score);
                break;

            case 2:
                PlayerPrefs.SetInt("ShiftScore2", Score);
                break;

            case 3:
                PlayerPrefs.SetInt("ShiftScore3", Score);
                break;

            case 4:
                PlayerPrefs.SetInt("ShiftScore4", Score);
                break;

            case 5:
                PlayerPrefs.SetInt("ShiftScore5", Score);
                break;

            case 6:
                PlayerPrefs.SetInt("ShiftScore6", Score);
                break;

            case 7:
                PlayerPrefs.SetInt("ShiftScore7", Score);
                break;

            case 8:
                PlayerPrefs.SetInt("ShiftScore8", Score);
                break;

            case 9:
                PlayerPrefs.SetInt("ShiftScore9", Score);
                break;

            case 10:
                PlayerPrefs.SetInt("ShiftScore10", Score);
                break;

            case 13:
                PlayerPrefs.SetInt("ShiftScore13", Score);
                break;

            case 14:
                PlayerPrefs.SetInt("ShiftScore14", Score);
                break;

            case 15:
                PlayerPrefs.SetInt("ShiftScore15", Score);
                break;

            case 16:
                PlayerPrefs.SetInt("ShiftScore16", Score);
                break;

            case 17:
                PlayerPrefs.SetInt("ShiftScore17", Score);
                break;

            case 18:
                PlayerPrefs.SetInt("ShiftScore18", Score);
                break;

            case 19:
                PlayerPrefs.SetInt("ShiftScore19", Score);
                break;

            case 20:
                PlayerPrefs.SetInt("ShiftScore20", Score);
                break;

            case 21:
                PlayerPrefs.SetInt("ShiftScore21", Score);
                break;

            case 22:
                PlayerPrefs.SetInt("ShiftScore22", Score);
                break;
        }
        PlayerPrefs.Save();
    }

    public int GetStepScore(int LevelNum)
    {
        switch (LevelNum)
        {
            case 1:
                return PlayerPrefs.GetInt("StepScore1");

            case 2:
                return PlayerPrefs.GetInt("StepScore2");

            case 3:
                return PlayerPrefs.GetInt("StepScore3");

            case 4:
                return PlayerPrefs.GetInt("StepScore4");

            case 5:
                return PlayerPrefs.GetInt("StepScore5");

            case 6:
                return PlayerPrefs.GetInt("StepScore6");

            case 7:
                return PlayerPrefs.GetInt("StepScore7");

            case 8:
                return PlayerPrefs.GetInt("StepScore8");

            case 9:
                return PlayerPrefs.GetInt("StepScore9");

            case 10:
                return PlayerPrefs.GetInt("StepScore10");

            case 13:
                return PlayerPrefs.GetInt("StepScore13");

            case 14:
                return PlayerPrefs.GetInt("StepScore14");

            case 15:
                return PlayerPrefs.GetInt("StepScore15");

            case 16:
                return PlayerPrefs.GetInt("StepScore16");

            case 17:
                return PlayerPrefs.GetInt("StepScore17");

            case 18:
                return PlayerPrefs.GetInt("StepScore18");

            case 19:
                return PlayerPrefs.GetInt("StepScore19");

            case 20:
                return PlayerPrefs.GetInt("StepScore20");

            case 21:
                return PlayerPrefs.GetInt("StepScore21");

            case 22:
                return PlayerPrefs.GetInt("StepScore22");
        }
        return 0;
    }

    public void SetStepScore(int LevelNum, int Score)
    {
        switch (LevelNum)
        {
            case 1:
                PlayerPrefs.SetInt("StepScore1", Score);
                break;

            case 2:
                PlayerPrefs.SetInt("StepScore2", Score);
                break;

            case 3:
                PlayerPrefs.SetInt("StepScore3", Score);
                break;

            case 4:
                PlayerPrefs.SetInt("StepScore4", Score);
                break;

            case 5:
                PlayerPrefs.SetInt("StepScore5", Score);
                break;

            case 6:
                PlayerPrefs.SetInt("StepScore6", Score);
                break;

            case 7:
                PlayerPrefs.SetInt("StepScore7", Score);
                break;

            case 8:
                PlayerPrefs.SetInt("StepScore8", Score);
                break;

            case 9:
                PlayerPrefs.SetInt("StepScore9", Score);
                break;

            case 10:
                PlayerPrefs.SetInt("StepScore10", Score);
                break;

            case 13:
                PlayerPrefs.SetInt("StepScore13", Score);
                break;

            case 14:
                PlayerPrefs.SetInt("StepScore14", Score);
                break;

            case 15:
                PlayerPrefs.SetInt("StepScore15", Score);
                break;

            case 16:
                PlayerPrefs.SetInt("StepScore16", Score);
                break;

            case 17:
                PlayerPrefs.SetInt("StepScore17", Score);
                break;

            case 18:
                PlayerPrefs.SetInt("StepScore18", Score);
                break;

            case 19:
                PlayerPrefs.SetInt("StepScore19", Score);
                break;

            case 20:
                PlayerPrefs.SetInt("StepScore20", Score);
                break;

            case 21:
                PlayerPrefs.SetInt("StepScore21", Score);
                break;

            case 22:
                PlayerPrefs.SetInt("StepScore22", Score);
                break;
        }
        PlayerPrefs.Save();
    }

    public void SetLevelPassed(int LevelNum)
    {
        switch (LevelNum)
        {
            case 1:
                PlayerPrefs.SetInt("Level1Passed", 1);
                break;

            case 2:
                PlayerPrefs.SetInt("Level2Passed", 1);
                break;

            case 3:
                PlayerPrefs.SetInt("Level3Passed", 1);
                break;

            case 4:
                PlayerPrefs.SetInt("Level4Passed", 1);
                break;

            case 5:
                PlayerPrefs.SetInt("Level5Passed", 1);
                break;

            case 6:
                PlayerPrefs.SetInt("Level6Passed", 1);
                break;

            case 7:
                PlayerPrefs.SetInt("Level7Passed", 1);
                break;

            case 8:
                PlayerPrefs.SetInt("Level8Passed", 1);
                break;

            case 9:
                PlayerPrefs.SetInt("Level9Passed", 1);
                break;

            case 10:
                PlayerPrefs.SetInt("Level10Passed", 1);
                break;

            case 13:
                PlayerPrefs.SetInt("Level13Passed", 1);
                break;

            case 14:
                PlayerPrefs.SetInt("Level14Passed", 1);
                break;

            case 15:
                PlayerPrefs.SetInt("Level15Passed", 1);
                break;

            case 16:
                PlayerPrefs.SetInt("Level16Passed", 1);
                break;

            case 17:
                PlayerPrefs.SetInt("Level17Passed", 1);
                break;

            case 18:
                PlayerPrefs.SetInt("Level18Passed", 1);
                break;

            case 19:
                PlayerPrefs.SetInt("Level19Passed", 1);
                break;

            case 20:
                PlayerPrefs.SetInt("Level20Passed", 1);
                break;

            case 21:
                PlayerPrefs.SetInt("Level21Passed", 1);
                break;

            case 22:
                PlayerPrefs.SetInt("Level22Passed", 1);
                break;
        }
        PlayerPrefs.Save();
    }

    public bool GetLevelPassed(int LevelNum)
    {
        switch (LevelNum)
        {
            case 1:
                if (PlayerPrefs.GetInt("Level1Passed") == 1)
                    return true;
                break;

            case 2:
                if (PlayerPrefs.GetInt("Level2Passed") == 1)
                    return true;
                break;

            case 3:
                if (PlayerPrefs.GetInt("Level3Passed") == 1)
                    return true;
                break;

            case 4:
                if (PlayerPrefs.GetInt("Level4Passed") == 1)
                    return true;
                break;

            case 5:
                if (PlayerPrefs.GetInt("Level5Passed") == 1)
                    return true;
                break;

            case 6:
                if (PlayerPrefs.GetInt("Level6Passed") == 1)
                    return true;
                break;

            case 7:
                if (PlayerPrefs.GetInt("Level7Passed") == 1)
                    return true;
                break;

            case 8:
                if (PlayerPrefs.GetInt("Level8Passed") == 1)
                    return true;
                break;

            case 9:
                if (PlayerPrefs.GetInt("Level9Passed") == 1)
                    return true;
                break;

            case 10:
                if (PlayerPrefs.GetInt("Level10Passed") == 1)
                    return true;
                break;

            case 13:
                if (PlayerPrefs.GetInt("Level13Passed") == 1)
                    return true;
                break;

            case 14:
                if (PlayerPrefs.GetInt("Level14Passed") == 1)
                    return true;
                break;

            case 15:
                if (PlayerPrefs.GetInt("Level15Passed") == 1)
                    return true;
                break;

            case 16:
                if (PlayerPrefs.GetInt("Level16Passed") == 1)
                    return true;
                break;

            case 17:
                if (PlayerPrefs.GetInt("Level17Passed") == 1)
                    return true;
                break;

            case 18:
                if (PlayerPrefs.GetInt("Level18Passed") == 1)
                    return true;
                break;

            case 19:
                if (PlayerPrefs.GetInt("Level19Passed") == 1)
                    return true;
                break;

            case 20:
                if (PlayerPrefs.GetInt("Level20Passed") == 1)
                    return true;
                break;

            case 21:
                if (PlayerPrefs.GetInt("Level21Passed") == 1)
                    return true;
                break;

            case 22:
                if (PlayerPrefs.GetInt("Level22Passed") == 1)
                    return true;
                break;
        }
        return false;
    }

    public void SaveRecentlyPassedLevel(int LevelNum)
    {
        PlayerPrefs.SetInt("RecentlyPassedLevel", LevelNum);
        PlayerPrefs.Save();
    }

    public int GetRecentlyPassedLevel()
    {
        if (PlayerPrefs.HasKey("RecentlyPassedLevel"))
            return PlayerPrefs.GetInt("RecentlyPassedLevel");
        else
            return 0;
    }

    public void PopUpResetProgress() 
    {
        foreach (GameObject b in Settings_Buttons)
        {
            b.GetComponent<Button>().interactable = false;
        }
        GameObject.FindGameObjectWithTag("WarningUI").GetComponent<Canvas>().enabled = true;
    }
    public void CloseResetProgress()
    {
        foreach (GameObject b in Settings_Buttons)
        {
            b.GetComponent<Button>().interactable = true;
        }
        GameObject.FindGameObjectWithTag("WarningUI").GetComponent<Canvas>().enabled = false;
    }

    public void ResetProgress()
    {
        CloseResetProgress();
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

    public void Exit()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }

    public bool GetAllLevelsPassed()
    {
        for(int i=1; i<11; i++)
        {
            if (!GetLevelPassed(i))
                return false;
        }
        for (int i = 13; i < 23; i++)
        {
            if (!GetLevelPassed(i))
                return false;
        }
        return true;
    }
}