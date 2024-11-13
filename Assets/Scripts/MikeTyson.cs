using System;
using System.Collections;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.Rendering;

public class MikeTyson : MonoBehaviour
{
    private Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float value = 0;

    [SerializeField] private Volume v;

    [SerializeField] float vv;
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        mat.SetFloat("_DissolveAmount", 0f);
        print(mat.name);
        StartCoroutine(GetWacked());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        print("head shot");
        mat.SetFloat("_DissolveAmount", value);
        value += 0.2f;
        print(value);
    }

    IEnumerator GetWacked()
    {
        yield return new WaitForSeconds(2f);
        print("punch");
        StartCoroutine(GetWacked());
        vv += 0.2f;
        v.weight = vv;

    }
}
