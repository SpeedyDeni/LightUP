using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskFollowCursor : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), speed);
    }
}
