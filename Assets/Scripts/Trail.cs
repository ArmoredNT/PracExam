using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    [SerializeField] private GameObject trail;
    
    
    private Camera _camera;
    private int amountCut;

    private bool shouldDissolve;

    private float t = 0;
    private float t2 = -1;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        trail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = _camera.nearClipPlane + 2.1f;
        Vector3 worldPosition = _camera.ScreenToWorldPoint(mousePos);
        trail.transform.position = worldPosition;

        if (Input.GetMouseButtonDown(0))
        {
            trail.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            trail.SetActive(false);
        }
        
    }

}
