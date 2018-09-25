using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class HealthScreenEffect : MonoBehaviour
{
    public float Health = 5;
    public bool DamageEffect = false;

    PostProcessVolume m_Volume;
    Vignette m_Vignette;
    Grain m_Grain;
    ChromaticAberration m_ChromaticAberration;
    ColorGrading m_ColorGrading;

    void Start()
    {
        //Vignette
        m_Vignette = ScriptableObject.CreateInstance<Vignette>();
        m_Vignette.enabled.Override(true);
        m_Vignette.intensity.Override(0.626f);

        //Grain
        m_Grain = ScriptableObject.CreateInstance<Grain>();
        m_Grain.enabled.Override(true);
        m_Grain.intensity.Override(1f);

        //ChromaticAberattion
        m_ChromaticAberration = ScriptableObject.CreateInstance<ChromaticAberration>();
        m_ChromaticAberration.enabled.Override(true);
        m_ChromaticAberration.intensity.Override(1f);

        //ColorGrading
        m_ColorGrading = ScriptableObject.CreateInstance<ColorGrading>();
        m_ColorGrading.enabled.Override(true);
        m_ColorGrading.temperature.Override(95);
        m_ColorGrading.saturation.Override(-61);
        m_ColorGrading.brightness.Override(-39);
        m_ColorGrading.contrast.Override(11);
        m_ColorGrading.mixerRedOutRedIn.Override(200);

        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Vignette, m_Grain, m_ChromaticAberration, m_ColorGrading);
    }

    void Update()
    {
        if (DamageEffect == true)
        {
            m_Vignette.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);
            m_Grain.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);
            m_ChromaticAberration.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);

            //ColorGrading Takes up a lot of space apparently...
            m_ColorGrading.saturation.value = Mathf.Sin(Time.realtimeSinceStartup);
            m_ColorGrading.brightness.value = Mathf.Sin(Time.realtimeSinceStartup);
            m_ColorGrading.contrast.value = Mathf.Sin(Time.realtimeSinceStartup);
            //m_ColorGrading.mixerRedOutRedIn.value = Mathf.Sin(Time.realtimeSinceStartup);
            //m_ColorGrading.temperature.value = Mathf.Sin(Time.realtimeSinceStartup);
        }
    }

    void OnDestroy()
    {
        RuntimeUtilities.DestroyVolume(m_Volume, true, true);
    }
}
