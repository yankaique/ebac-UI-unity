using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class ScriptsUtils
{
    // extensions
    public static T GetRandom<T>(this T[] array)
    {
        if(array.Length == 0)
        {
            return default(T);
        }

        return array[Random.Range(0, array.Length)];
    }
}
