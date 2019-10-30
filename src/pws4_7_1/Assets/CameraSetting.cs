using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;
        transform.parent = cam.transform;

        float dist = cam.farClipPlane - 3.0f;
        transform.localPosition = new Vector3(0, 0, dist);
        transform.localRotation = new Quaternion();

        float inv_aspect = (float)Screen.width / (float)Screen.height;
        float s = Mathf.Tan(0.5f * cam.fieldOfView * Mathf.Deg2Rad) * 2.0f * dist;
        transform.localScale = new Vector3(inv_aspect * s, s, 1);
    }
}
