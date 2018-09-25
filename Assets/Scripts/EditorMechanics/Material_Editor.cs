using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Material_Editor : MonoBehaviour
{

    public Button AlbedoBut;
    public Button TexBut;

    public Texture m_MainTexture;
    //var Col;

    void Start()
    {

        Button btn = AlbedoBut.GetComponent<Button>();
        btn.onClick.AddListener(SetMaterialColor);
        Button btn1 = TexBut.GetComponent<Button>();
        btn1.onClick.AddListener(SetTexture);

    }

    void SetMaterialColor()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.cyan);

    }

    void SetTexture()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetTexture("_MainTex", m_MainTexture);
    }
}
