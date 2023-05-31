using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightBlink : MonoBehaviour
{
    private void Start()
    {
        _light = GetComponent<Light>();

        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        yield return new WaitForSeconds(RandomTime());

        float previousIntensity = _light.intensity;
        _light.intensity = 0;

        yield return new WaitForSeconds(RandomTime());

        _light.intensity = 1;


        StartCoroutine(Blink());
    }

    private float RandomTime()
    {
        float time = Random.Range(0.0f, _maxTime);
        return time;
    }

    [SerializeField] float _maxTime;
    private Light _light;
}