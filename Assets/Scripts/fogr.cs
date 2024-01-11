using UnityEngine;
using System.Collections;

public class fogr : MonoBehaviour
{

    public bool isFogOnOff = false;

    public Color RkFogColor;

    public enum RkFogMode : int
    {
        Linear = 0,
        Expotential = 1,
        ExpotentialSquared = 2,
    }

    public RkFogMode RkFogModeEnum;

    public float LinearStart = 0.0f;
    public float LinearEnd = 10.0f;

    public float ExpotentialDensity = 0.01f;


    // Use this for initialization
    void Start()
    {

        if (isFogOnOff == true)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = RkFogColor;

            if ((int)RkFogModeEnum == 0)
            {
                RenderSettings.fogMode = FogMode.Linear;
                RenderSettings.fogStartDistance = LinearStart;
                RenderSettings.fogEndDistance = LinearEnd;
            }
            if ((int)RkFogModeEnum == 1)
            {
                RenderSettings.fogMode = FogMode.Exponential;
                RenderSettings.fogDensity = ExpotentialDensity;
            }
            if ((int)RkFogModeEnum == 2)
            {
                RenderSettings.fogMode = FogMode.ExponentialSquared;
                RenderSettings.fogDensity = ExpotentialDensity;
            }

        }
        else
        {
            RenderSettings.fog = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}