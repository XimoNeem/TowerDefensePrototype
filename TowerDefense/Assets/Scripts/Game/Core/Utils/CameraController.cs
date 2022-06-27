using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _smoothingSpeed = 5;
    [SerializeField] private Vector3 _zOffset = new Vector3(0, 0, -10);

    private Coroutine _coroutine;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    public void MoveCamera(Vector3 target)
    {
        if (_coroutine != null) { StopCoroutine(_coroutine); }
        _coroutine = StartCoroutine(MoveCameraTo(target));
    }
    private IEnumerator MoveCameraTo(Vector3 target)
    {
        while (_camera.transform.position != (target + _zOffset))
        {
            _camera.transform.position = Vector3.Lerp(_camera.transform.position, target + _zOffset, Time.deltaTime * _smoothingSpeed);
            yield return new WaitForEndOfFrame();
        }
        if (_coroutine != null) { StopCoroutine(_coroutine); }
    }
}
