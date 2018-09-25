using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightEditor : MonoBehaviour
{
    public Button IntenseBut;
    public Button LightColBut;
    public Button DayCycleBut;

    bool IsLightTransition = false;

    //LightIntensityStuffs
    public float duration = 1.0f;
    public Light lit;

    //LightColorStuffs
    public int ColorSel = 0;
    public Light litCol;
    public Color col0 = Color.magenta;
    public Color col1 = Color.blue;
    public Color col2 = Color.green;

    //TimeOfDayStuffs
    public int DaySel = 0;
    public Light litTime;
    bool litDay = false;
    bool litEven = false;
    bool litNight = false;

    void Start()
    {
        Button btn = IntenseBut.GetComponent<Button>();
        btn.onClick.AddListener(SetLightIntensity);

        Button btn1 = LightColBut.GetComponent<Button>();
        btn1.onClick.AddListener(SetLightColor);

        Button btn2 = DayCycleBut.GetComponent<Button>();
        btn2.onClick.AddListener(SwitchTimeOfDay);

    }


    void SetLightIntensity()
    {
        IsLightTransition = true;
    }

    void SetLightColor()
    {
        litCol = GetComponent<Light>();

        switch (ColorSel++)
        {
            case 0:
                litCol.color = col0;
                break;
            case 1:
                litCol.color = col1;
                break;
            case 2:
                litCol.color = col2;
                break;

        }

    }

    void SwitchTimeOfDay()
    {
        litTime = GetComponent<Light>();

        switch (DaySel++)
        {
            case 0:
                litDay = true;
                break;
            case 1:
                litEven = true;
                litDay = false;
                if (litEven == true)
                {
                    litTime.transform.Rotate(Vector3.up, Time.deltaTime, Space.World);
                }
                break;
            case 2:
                litEven = false;
                litNight = true;
                if (litNight == true)
                {
                    //litTime.transform.Rotate(0, Time.deltaTime, Space.World);
                }
                break;
            default:
                Debug.Log("Unknown option");
                break;
        }

    }

    void Update()
    {
        if (litDay == true)
        {
            litTime.transform.Rotate(Time.deltaTime * 20, 0, 0);
        }

        if (IsLightTransition == true)
        {
            lit = GetComponent<Light>();
            float phi = Time.time / duration * 0.5f * Mathf.PI;
            float amplitude = Mathf.Cos(phi) * 5f + 0.5f;
            lit.intensity = amplitude;
        }


    }
    
}
