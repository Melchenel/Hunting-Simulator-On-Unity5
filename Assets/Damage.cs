using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Damage : MonoBehaviour
{
    public Slider slider;
    // Use this for initialization
    void Start()
    {
        slider.value = 100;
    }

    private void OnTriggerStay(Collider other)
    {
        slider.value -= 2 * Time.deltaTime;
        if (slider.value == 0)
        {
            SceneManager.LoadScene("1");
        }
    }
}
