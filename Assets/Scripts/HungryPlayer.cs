using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HungryPlayer : MonoBehaviour {
    public int hungry;
    public Slider slider;
    public int SliderSpeed = 2;
    private bool flag = false;
    public int health;
    public Slider sliderHealth;
	// Use this for initialization
	void Start () {
        slider.value = hungry;
        sliderHealth.value = health;
	}
	
	// Update is called once per frame
	void Update () {
        if (slider.value > 0)
            slider.value -= Time.deltaTime * SliderSpeed;
        else slider.value = 0;

        if(slider.value == 0)
        {
            flag = true;
        }

        if(flag == true)
        {
            if(sliderHealth.value > 0)
            sliderHealth.value -= Time.deltaTime * SliderSpeed;
        else sliderHealth.value = 0; 
        }
        if (flag == true && sliderHealth.value == 0)
        {
            SceneManager.LoadScene("1");
        }
            

	}
}
