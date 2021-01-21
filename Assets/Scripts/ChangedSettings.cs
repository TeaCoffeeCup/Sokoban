using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangedSettings : MonoBehaviour
{
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "MusicSlider" && PlayerPrefs.HasKey("MusicVol"))
        {
            GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVol");
            GameObject.FindGameObjectWithTag("MusicPlayer").GetComponent<AudioSource>().volume = GetComponent<Slider>().value;
        }
        else if (gameObject.tag == "SFXSlider" && PlayerPrefs.HasKey("SFXVol"))
        {
            GetComponent<Slider>().value = PlayerPrefs.GetFloat("SFXVol");
            GameObject.FindGameObjectWithTag("SFXPlayer").GetComponent<AudioSource>().volume = GetComponent<Slider>().value;
        }
        else if(gameObject.tag == "MusicSliderInGame" && PlayerPrefs.HasKey("MusicVol"))
        {
            GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVol");
        }
        else if (gameObject.tag == "SFXSliderInGame" && PlayerPrefs.HasKey("SFXVol"))
        {
            GetComponent<Slider>().value = PlayerPrefs.GetFloat("SFXVol");
        }
    }

    // Update is called once per frame
    public void MusicSliderChanged()
    {
        GameObject.FindGameObjectWithTag("MusicPlayer").GetComponent<AudioSource>().volume = GetComponent<Slider>().value;
        Camera.GetComponent<MainCamera>().MusicVolume = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("MusicVol", GetComponent<Slider>().value);
        PlayerPrefs.Save();
        if(gameObject.tag == "MusicSlider")
            GameObject.FindGameObjectWithTag("MusicSliderInGame").GetComponent<Slider>().value = GetComponent<Slider>().value;
        else
            GameObject.FindGameObjectWithTag("MusicSlider").GetComponent<Slider>().value = GetComponent<Slider>().value;
    }
    public void SFXSliderChanged()
    {
        GameObject.FindGameObjectWithTag("SFXPlayer").GetComponent<AudioSource>().volume = GetComponent<Slider>().value;
        Camera.GetComponent<MainCamera>().SFXVolume = GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("SFXVol", GetComponent<Slider>().value);
        PlayerPrefs.Save();
        if (gameObject.tag == "SFXSlider")
            GameObject.FindGameObjectWithTag("SFXSliderInGame").GetComponent<Slider>().value = GetComponent<Slider>().value;
        else
            GameObject.FindGameObjectWithTag("SFXSlider").GetComponent<Slider>().value = GetComponent<Slider>().value;
    }
}
