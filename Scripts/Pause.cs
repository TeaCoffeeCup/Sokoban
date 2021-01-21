using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool Paused = false;
    public bool InGame = false;
    public GameObject[] Players, Boxes, BoxedLevels;
    public GameObject MenuPlayer;
    public Transform MainMenu;
    public Button Next;
    int recentlyPassed;
    private bool moved = true;
    public Button StepBackButton;
    // Start is called before the first frame update
    private void Update()
    {
        if (!moved)
        {
            foreach (GameObject p in Players)
            {
                if (p.GetComponent<Player>().Moved)
                {
                    moved = true;
                    StepBackButton.interactable = true;
                    break;
                }
            }
        }
    }
    public void SetPause(bool State)
    {
        Paused = State;

        if (InGame)
        {
            if (State)
            {
                GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = false;
                GameObject.FindGameObjectWithTag("PausedUI").GetComponent<Canvas>().enabled = true;
            }
            else
            {
                GameObject.FindGameObjectWithTag("PausedUI").GetComponent<Canvas>().enabled = false;
                GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
            }
        }
    }

    public void HideAll()
    {
        Paused = false;
        InGame = false;
        GameObject.FindGameObjectWithTag("PausedUI").GetComponent<Canvas>().enabled = false;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = false;
        GameObject.FindGameObjectWithTag("PassedUI").GetComponent<Canvas>().enabled = false;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = false;
    }

    public void RestartSceneForRestartButton()
    {
        RestartScene(false, true);
    }

    public void RestartSceneForHomeButton()
    {
        RestartScene(true);
    }

    public void RestartScene(bool GoHome, bool switching = false)
    {
        Next.interactable = true;
        print("restaring");
        SetPause(false);
        
        foreach (GameObject p in Players)
        {
            p.GetComponent<Player>().RestartLevel(switching);
        }
        foreach (GameObject b in Boxes)
        {
            b.GetComponent<Crate>().RestartLevel();
        }
        print("Closing Window");
        GameObject.FindGameObjectWithTag("PassedUI").GetComponent<Canvas>().enabled = false;
        if (GoHome)
        {
            foreach (GameObject p in Players)
            {
                p.GetComponent<Player>().canMove = false;
            }
            MenuPlayer.GetComponent<Player>().canMove = true;
            HideAll();
            GetComponentInParent<MainCamera>().Moving = true;
            GetComponentInParent<MainCamera>().TargetMovingTo = MainMenu;
            GameObject.FindGameObjectWithTag("PassedUI").GetComponent<Canvas>().enabled = false;
        }
        print("ended try");
    }

    public void PassedLevel(int LevelPassed)
    {
        GameObject.FindGameObjectWithTag("PassedUI").GetComponent<Canvas>().enabled = true;
        recentlyPassed = LevelPassed;
        GetComponent<Saver>().SaveRecentlyPassedLevel(LevelPassed);
    }

    public void SwitchLevel()
    {
        RestartScene(false);
        Paused = false;
        GameObject.FindGameObjectWithTag("PassedUI").GetComponent<Canvas>().enabled = false;
        if (recentlyPassed == 2)
            GetComponent<LevelSelector>().ChangeTo13();
        else if (recentlyPassed == 22)
            GetComponent<LevelSelector>().ChangeTo3();
        else
            switch (recentlyPassed + 1)
            {
                case 2:
                    GetComponent<LevelSelector>().ChangeTo2();
                    break;

                case 4:
                    GetComponent<LevelSelector>().ChangeTo4();
                    break;

                case 5:
                    GetComponent<LevelSelector>().ChangeTo5();
                    break;

                case 6:
                    GetComponent<LevelSelector>().ChangeTo6();
                    break;

                case 7:
                    GetComponent<LevelSelector>().ChangeTo7();
                    break;

                case 8:
                    GetComponent<LevelSelector>().ChangeTo8();
                    break;

                case 9:
                    GetComponent<LevelSelector>().ChangeTo9();
                    break;

                case 10:
                    GetComponent<LevelSelector>().ChangeTo10();
                    break;

                case 14:
                    GetComponent<LevelSelector>().ChangeTo14();
                    break;

                case 15:
                    GetComponent<LevelSelector>().ChangeTo15();
                    break;

                case 16:
                    GetComponent<LevelSelector>().ChangeTo16();
                    break;

                case 17:
                    GetComponent<LevelSelector>().ChangeTo17();
                    break;

                case 18:
                    GetComponent<LevelSelector>().ChangeTo18();
                    break;

                case 19:
                    GetComponent<LevelSelector>().ChangeTo19();
                    break;

                case 20:
                    GetComponent<LevelSelector>().ChangeTo20();
                    break;

                case 21:
                    GetComponent<LevelSelector>().ChangeTo21();
                    break;

                case 22:
                    GetComponent<LevelSelector>().ChangeTo22();
                    break;
            }
    }

    public void ShowInfo(GameObject InfoButton)
    {
        Paused = true;
        InfoButton.GetComponent<Button>().interactable = false;
        GameObject.FindGameObjectWithTag("InfoUI").GetComponent<Canvas>().enabled = true;
    }
    public void CloseInfo(GameObject InfoButton)
    {
        Paused = false;
        InfoButton.GetComponent<Button>().interactable = true;
        GameObject.FindGameObjectWithTag("InfoUI").GetComponent<Canvas>().enabled = false;
    }

    public void StepBack()
    {
        foreach (GameObject p in Players)
        {
            p.GetComponent<Player>().OneStepBack();
            p.GetComponent<Player>().Moved = false;
        }
        foreach (GameObject b in Boxes)
        {
            b.GetComponent<Crate>().OneStepBack();
        }
        moved = false;
        StepBackButton.interactable = false;
        Debug.Log("Stepped back");
    }
}
