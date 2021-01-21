using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetParent : MonoBehaviour
{
    public GameObject[] Targets;
    public bool[] targetsValues;
    public int LevelNum;
    public Button Next;
    public Player player;
    public AudioClip WinSound;
    void Update()
    {
        for(int i = 0; i<Targets.Length; i++)
        {
            targetsValues[i] = Targets[i].GetComponent<TargetTileScript>().boxed;
        }
        bool passed = true;
        foreach(bool i in targetsValues)
        {
            if (!i)
            {
                passed = false;
                break;
            }
        }
        bool NewRecord = false;
        if (passed && !GameObject.FindWithTag("MainCamera").GetComponent<MainCamera>().Moving && player.Moved && LevelNum != 10)
        {
            player.Moved = false;
            GameObject.FindWithTag("MainCamera").GetComponent<Saver>().SetLevelPassed(LevelNum);
            GameObject.FindWithTag("MainCamera").GetComponent<Pause>().Paused = true;
            GameObject.FindWithTag("MainCamera").GetComponent<Pause>().PassedLevel(LevelNum);
            Next.interactable = true;
            if (GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetShiftScore(LevelNum) > player.shifts || GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetShiftScore(LevelNum) == 0)
            {
                NewRecord = true;
                GameObject.FindWithTag("MainCamera").GetComponent<Saver>().SetShiftScore(LevelNum, player.shifts);
            }
            if (GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetStepScore(LevelNum) > player.shifts || GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetStepScore(LevelNum) == 0)
            {
                NewRecord = true;
                GameObject.FindWithTag("MainCamera").GetComponent<Saver>().SetStepScore(LevelNum, player.steps);
            }
            if (NewRecord)
            {
                GameObject.FindWithTag("SFXPlayer").GetComponent<AudioSource>().PlayOneShot(WinSound);
            }
        }
        else if (passed && !GameObject.FindWithTag("MainCamera").GetComponent<MainCamera>().Moving && LevelNum == 10 && player.Moved)
        {
            player.Moved = false;
            GameObject.FindWithTag("MainCamera").GetComponent<Saver>().SetLevelPassed(LevelNum);
            GameObject.FindWithTag("MainCamera").GetComponent<Pause>().Paused = true;
            GameObject.FindWithTag("MainCamera").GetComponent<Pause>().PassedLevel(LevelNum);
            Next.interactable = false;
            if (GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetShiftScore(LevelNum) > player.shifts || GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetShiftScore(LevelNum) == 0)
            {
                NewRecord = true;
                GameObject.FindWithTag("MainCamera").GetComponent<Saver>().SetShiftScore(LevelNum, player.shifts);
            }
            if (GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetStepScore(LevelNum) > player.shifts || GameObject.FindWithTag("MainCamera").GetComponent<Saver>().GetStepScore(LevelNum) == 0)
            {
                NewRecord = true;
                GameObject.FindWithTag("MainCamera").GetComponent<Saver>().SetStepScore(LevelNum, player.steps);
            }
            if (NewRecord)
            {
                GameObject.FindWithTag("SFXPlayer").GetComponent<AudioSource>().PlayOneShot(WinSound);
            }
        }
    }
}
