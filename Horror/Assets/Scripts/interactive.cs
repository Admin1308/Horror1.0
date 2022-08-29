using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{

    [SerializeField] private Camera fpsCamera;
    private Ray _ray;
    private RaycastHit _hit;
    private GameObject gamesObject;
    private bool Examination = false;

    [SerializeField ]private float _maxDistanceRey;

    private void Update()
    {
        Ray();
        DrawRey();
    }
    private void Ray ()
    {
        _ray = fpsCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }
        
    private void DrawRey()
    {
        if (Physics.Raycast(_ray, out _hit, _maxDistanceRey))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRey, Color.red);
        }
        if (_hit.transform == null)
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRey, Color.blue);
        }
        
    }
}
