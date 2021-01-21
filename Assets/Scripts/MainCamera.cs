using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MainCamera : MonoBehaviour
{
    public bool Moving;
    public Transform TargetMovingTo;
    public float speed;
    public float MusicVolume, SFXVolume;
    public int ButtonPressed = 4;
    void Update()
    {
        if (Moving)
            transform.position = Vector3.Lerp(transform.position, new Vector3(TargetMovingTo.transform.position.x, TargetMovingTo.transform.position.y, transform.position.z), speed * Time.deltaTime);
        if ((transform.position.x >= TargetMovingTo.transform.position.x-0.1 && transform.position.x <= TargetMovingTo.transform.position.x + 0.1) && (transform.position.y >= TargetMovingTo.transform.position.y - 0.1 && transform.position.y <= TargetMovingTo.transform.position.y + 0.1))
            Moving = false;
    }

    public void SetButtonPressed(int direction)
    {
        ButtonPressed = direction;
    }

    public void SetButtonUp()
    {
        ButtonPressed = 4;
    }
}
