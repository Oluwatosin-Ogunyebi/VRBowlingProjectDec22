using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    [SerializeField] private GameObject[] _env;
    private Material _defaultSkybox;


    private void Start()
    {
        _defaultSkybox = RenderSettings.skybox;
    }
    public void SwitchEnv(int i)
    {
        foreach (GameObject item in _env)
            item.SetActive(false);
        if (i>=0)
            _env[i].SetActive(true);


    }

    public void SetDefaultSkybox()
    {
        RenderSettings.skybox = _defaultSkybox;
        SwitchEnv(-1);
    }
}
