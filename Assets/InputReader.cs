using UnityEngine;

public class InputReader : MonoBehaviour
{
    public bool TapDown(out Vector2 pos)
    {
        pos = Vector2.zero;

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            pos = Input.mousePosition;
            return true;
        }
#else
        if (Input.touchCount == 1 &&
            Input.GetTouch(0).phase == TouchPhase.Began)
        {
            pos = Input.GetTouch(0).position;
            return true;
        }
#endif
        return false;
    }

    public bool TapUp(out Vector2 pos)
    {
        pos = Vector2.zero;

#if UNITY_EDITOR
        if (Input.GetMouseButtonUp(0))
        {
            pos = Input.mousePosition;
            return true;
        }
#else
        if (Input.touchCount == 1 &&
            Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            pos = Input.GetTouch(0).position;
            return true;
        }
#endif
        return false;
    }
}