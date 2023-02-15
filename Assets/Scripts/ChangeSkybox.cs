using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    [SerializeField] private Material _skyboxMaterial;
    
    private void OnEnable()
    {
        RenderSettings.skybox = _skyboxMaterial;
    }


}
