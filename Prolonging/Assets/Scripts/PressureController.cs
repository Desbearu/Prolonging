using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureController : MonoBehaviour
{
    public float Pressure = 0;
    public double PressureLimit = 235;
    public double PressureExtreme = 360;

    public AudioSource pressureWarningSound;

    public GameObject pressureLight;
    public GameObject pressureButton;
    private GameObject lightAsset;
    // Start is called before the first frame update
    void Start()
    {
        lightAsset = GameObject.Find("pressao-luz-acesa");
    }

    // Update is called once per frame
    void Update()
    {
        if(Pressure < PressureExtreme){
            Pressure += 0.001f;
        }

        if(Pressure > PressureLimit){
            if(pressureWarningSound.isPlaying == false){
                pressureWarningSound.Play();
            }

            lightAsset.SetActive(true);
            pressureLight.SetActive(true);
        }
        else{
            pressureWarningSound.Stop();
            lightAsset.SetActive(false);
            pressureLight.SetActive(false);
        }
    }
}
