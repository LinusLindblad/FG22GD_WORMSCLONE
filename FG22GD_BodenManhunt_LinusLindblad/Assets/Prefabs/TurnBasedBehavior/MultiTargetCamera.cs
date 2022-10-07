 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class MultiTargetCamera : MonoBehaviour
{
    private Transform _currentCamera;
    private Transform _mainCamT;
    private Camera _mainCamera;
    private Vignette _vignette;
    private bool _vignetteClosed;

    //private float _transStartDistance;
    //private Vector3 _directionToNewCam;
    //private Quaternion _lookRotationToNewCam;

    public bool TransitionComplete = true;
    public Volume PostPVolume;

    private void Awake()
    {
        PostPVolume.profile.TryGet(out _vignette);

        _mainCamera = Camera.main;
        _mainCamT = _mainCamera.transform;
    }

    public void SwapCamera(Transform newCam)
    {
        //_transStartDistance = Vector3.Distance(_mainCamera.transform.position, newCam.position);
        _mainCamera.transform.parent = null;
        _currentCamera = newCam;
        TransitionComplete = false;

        //directionToNewCam = (newCam.position - _mainCamT.position).normalized;
        //_lookRotationToNewCam = Quaternion.LookRotation(_directionToNewCam);
    }

    private void Update()
    {
        if (TransitionComplete == false)
        {
            if(_vignette.intensity.value < 0.3f && _vignetteClosed == false)
            {
                _vignette.intensity.value = Mathf.Lerp(_vignette.intensity.value, 0.5f, 1f * Time.deltaTime);
            }
            else if(_vignetteClosed == false)
            {
                _vignette.intensity.value = 0.3f;
                _vignetteClosed = true;

                _mainCamT.rotation = _currentCamera.rotation;
                _mainCamT.position = _currentCamera.position;
            }

            if(_vignette.intensity.value > 0.05f && _vignetteClosed == true)
            {
                _vignette.intensity.value = Mathf.Lerp(_vignette.intensity.value, 0f, 1f * Time.deltaTime);
            }
            else if (_vignetteClosed == true)
            {
                _vignette.intensity.value = 0f;
                TransitionComplete = true;
                _vignetteClosed = false;
            }
        }
        else
        {
            _mainCamT.rotation = _currentCamera.rotation;
            _mainCamT.position = _currentCamera.position;
        }


        /*
        if(TransitionComplete == false)
        {
            if (Vector3.Distance(_mainCamT.position, _currentCamera.position) >= _transStartDistance/6)
            {
                //Smoothly lerps the camera towards the new player while looking at it
                _mainCamT.position = Vector3.Lerp(_mainCamT.position, _currentCamera.position, 1.25f * Time.deltaTime);
                _mainCamT.rotation = Quaternion.Lerp(_mainCamT.rotation, _lookRotationToNewCam, 2.5f * Time.deltaTime);
            }
            else if(Vector3.Distance(_mainCamT.position, _currentCamera.position) <= 0.05f)
            {
                //_mainCamT.transform.parent = _currentCamera;
                _mainCamT.rotation = _currentCamera.rotation;
                _mainCamT.position = _currentCamera.position;
                TransitionComplete = true;
            }
            else
            {
                //Swaps to movetowards to prevent jerky movement when locking the camera
                _mainCamT.position = Vector3.MoveTowards(_mainCamT.position, _currentCamera.position, 2.5f * Time.deltaTime);

                //Rotates the camera to fit the new player's view
                _mainCamT.rotation = Quaternion.Lerp(_mainCamT.rotation, _currentCamera.rotation, 5f * Time.deltaTime);
            }
        }
        else
        {
            _mainCamT.rotation = _currentCamera.rotation;
            _mainCamT.position = _currentCamera.position;
        }
        */
    }
}
