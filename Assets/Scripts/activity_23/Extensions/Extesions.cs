using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Public.Extensions
{
    public static class Extesions
    {
        public static T GetRandom<T>(this List<T> array)
        {
            return array[Random.Range(0, array.Count)];
        }

        public static List<GameObject> FilterByTag(this List<GameObject> list, string tag)
        {
            List<GameObject> filteredList = new List<GameObject>();
            foreach (GameObject item in list)
            {
                if (item.CompareTag(tag))
                {
                    filteredList.Add(item);
                }
            }

            return filteredList;
        }
    }
}
