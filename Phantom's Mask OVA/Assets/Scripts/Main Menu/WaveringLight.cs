using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveringLight : MonoBehaviour {
    Light flicker;
    public float rate;
    public float max;
    private bool increasing;
    private bool decreasing;
    private float intensity;
    // Use this for initialization
    void Start () {
        flicker = GetComponent<Light>();
        flicker.intensity = 0.1f;
        intensity = 0;
        increasing = true;
        decreasing = false;
        StartCoroutine(Flashing());
    }


    IEnumerator Flashing()
    { 
        while (true)
        {
            yield return new WaitForSeconds(rate);
            Debug.Log(flicker.intensity);
            if (intensity >= max)
            {
                decreasing = true;
                increasing = false;
                flicker.intensity -=  0.05f;
                intensity -= 0.05f;
            }
            else if(intensity <= 0)
            {
                increasing = true;
                decreasing = false;
                flicker.intensity += 0.05f;
                intensity += 0.05f;
            }
            else if (increasing)
            {
                flicker.intensity += 0.05f;
                intensity += 0.05f;
            }

            else if (decreasing)
            {
                flicker.intensity -= 0.05f;
                intensity -= 0.05f;
            }
            
        }
    }
}
