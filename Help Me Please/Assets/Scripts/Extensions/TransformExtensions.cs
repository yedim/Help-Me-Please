﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{

    public static IEnumerator Move(this Transform t, Vector3 target, float duration)
    {
        Vector3 diffVector = (target - t.position);
        float diffLength = diffVector.magnitude;
        diffVector.Normalize();
        float counter = 0;

        while (counter < duration)
        {
            float moveAmount = (Time.deltaTime * diffLength) / duration;
            t.position += diffVector * moveAmount;
            counter += Time.deltaTime;
            yield return null;
        }
        t.position = target;
    }
}
