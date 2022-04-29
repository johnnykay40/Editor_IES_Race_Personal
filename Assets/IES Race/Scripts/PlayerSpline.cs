using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpline : MonoBehaviour
{
   public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
    {
        return a + (b - a) * t;
    }
}
