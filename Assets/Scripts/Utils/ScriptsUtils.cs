using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class ScriptsUtils
{
    // extensions
    public static T GetRandom<T>(this List<T> array)
    {

        return array[Random.Range(0, array.Count)];
    }
}
