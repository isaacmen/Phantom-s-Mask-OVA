using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {
    Light flicker;
    public float min;
    public float max;
    // Use this for initialization
    void Start()
    {
        flicker = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(min, max));
            flicker.enabled = !flicker.enabled;
        }
    }
}
