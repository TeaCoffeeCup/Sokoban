using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Transform Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10, Level13, Level14, Level15, Level16, Level17, Level18, Level19, Level20, Level21, Level22;
    public GameObject[] Players;
    public float speed;
    public Text ShiftScore, StepScore, Shift, Step, txtRecord;
    public int CurrentLevel = 1;
    int i;

    void Update()
    {
        if (GetComponent<Saver>().GetShiftScore(CurrentLevel) != 0)
            ShiftScore.text = GetComponent<Saver>().GetShiftScore(CurrentLevel).ToString();
        else
            ShiftScore.text = "None";

        if (GetComponent<Saver>().GetStepScore(CurrentLevel) != 0)
            StepScore.text = GetComponent<Saver>().GetStepScore(CurrentLevel).ToString();
        else
            StepScore.text = "None";
    }

    public void UpdateShift(int shifts)
    {
        Shift.text = shifts.ToString();
        if (GetComponent<Saver>().GetShiftScore(CurrentLevel) != 0)
            if (GetComponent<Saver>().GetShiftScore(CurrentLevel) < shifts)
                Shift.color = new Color(255, 0, 0);
            else if (GetComponent<Saver>().GetShiftScore(CurrentLevel) == shifts)
                Shift.color = new Color(255, 69, 0);
            else if (GetComponent<Saver>().GetShiftScore(CurrentLevel) > shifts)
                Shift.color = new Color(0, 255, 0);
    }

    public void UpdateStep(int steps)
    {
        Step.text = steps.ToString();
        if (GetComponent<Saver>().GetShiftScore(CurrentLevel) != 0)
            if (GetComponent<Saver>().GetStepScore(CurrentLevel) < steps)
                Step.color = new Color(255, 0, 0);
            else if (GetComponent<Saver>().GetStepScore(CurrentLevel) == steps)
                Step.color = new Color(255, 69, 0);
            else if (GetComponent<Saver>().GetStepScore(CurrentLevel) > steps)
                Step.color = new Color(0, 255, 0);
    }

    public void StartBlinking()
    {
        i = 0;
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        i++;
        if (txtRecord.color == new Color(0, 255, 0))
            txtRecord.color = new Color(255, 255, 0);
        else
            txtRecord.color = new Color(0, 255, 0);
        if (i == 10)
        {
            i = 0;
            txtRecord.color = new Color(0, 255, 0);
            StopCoroutine(Blink());
        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Blink());
    }

    public void ChangeTo1()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level1;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[0].GetComponent<Player>().canMove = true;
        CurrentLevel = 1;
    }
    public void ChangeTo2()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level2;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[1].GetComponent<Player>().canMove = true;
        CurrentLevel = 2;
    }

    public void ChangeTo3()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level3;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[2].GetComponent<Player>().canMove = true;
        CurrentLevel = 3;
    }

    public void ChangeTo4()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level4;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[3].GetComponent<Player>().canMove = true;
        CurrentLevel = 4;
    }

    public void ChangeTo5()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level5;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[4].GetComponent<Player>().canMove = true;
        CurrentLevel = 5;
    }

    public void ChangeTo6()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level6;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[5].GetComponent<Player>().canMove = true;
        CurrentLevel = 6;
    }

    public void ChangeTo7()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level7;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[6].GetComponent<Player>().canMove = true;
        CurrentLevel = 7;
    }
    public void ChangeTo8()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level8;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[7].GetComponent<Player>().canMove = true;
        CurrentLevel = 8;
    }

    public void ChangeTo9()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level9;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[8].GetComponent<Player>().canMove = true;
        CurrentLevel = 9;
    }

    public void ChangeTo10()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level10;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[9].GetComponent<Player>().canMove = true;
        CurrentLevel = 10;
    }

    public void ChangeTo13()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level13;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[10].GetComponent<Player>().canMove = true;
        CurrentLevel = 13;
    }
    public void ChangeTo14()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level14;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[11].GetComponent<Player>().canMove = true;
        CurrentLevel = 14;
    }
    public void ChangeTo15()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level15;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[12].GetComponent<Player>().canMove = true;
        CurrentLevel = 15;
    }
    public void ChangeTo16()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level16;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[13].GetComponent<Player>().canMove = true;
        CurrentLevel = 16;
    }
    public void ChangeTo17()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level17;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[14].GetComponent<Player>().canMove = true;
        CurrentLevel = 17;
    }

    public void ChangeTo18()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level18;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[15].GetComponent<Player>().canMove = true;
        CurrentLevel = 18;
    }
    public void ChangeTo19()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level19;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[16].GetComponent<Player>().canMove = true;
        CurrentLevel = 19;
    }
    public void ChangeTo20()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level20;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[17].GetComponent<Player>().canMove = true;
        CurrentLevel = 20;
    }
    public void ChangeTo21()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level21;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[18].GetComponent<Player>().canMove = true;
        CurrentLevel = 21;
    }
    public void ChangeTo22()
    {
        GetComponent<MainCamera>().Moving = true;
        GetComponent<MainCamera>().TargetMovingTo = Level22;
        GetComponent<MainCamera>().speed = speed;
        GameObject.FindGameObjectWithTag("InGameUI").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
        GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Pause>().InGame = true;
        Players[19].GetComponent<Player>().canMove = true;
        CurrentLevel = 22;
    }
}
