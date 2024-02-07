using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace InnScripts
{
    public static class TagManager 
    {
        public static bool HasTag(this GameObject gameObject, Tag tag)
        {
            return gameObject.TryGetComponent<Tags>(out var tags) && tags.HasTag(tag);            
        }
        public static bool HasTag(this GameObject gameObject, string tagName)
        {
            return gameObject.TryGetComponent<Tags>(out var tags) && tags.HasTag(tagName);
        }

        public static void RemoveTag(this GameObject gameObject, string tagName)
        {
            if(gameObject.TryGetComponent<Tags>(out var tags))
            {
                tags.Remove(tagName);
            }
        }
        public static void ClearTags(this GameObject gameObject)
        {
            if(gameObject.TryGetComponent<Tags>(out var tags))
            {                
                tags.RemoveAll();                
            }
        }
        public static void AddTag(this GameObject gameObject, string tagName)
        {
            if (gameObject.TryGetComponent<Tags>(out var tags))
            {
                tags.AddTag(tagName);
            }
        }
        public static void AddTag(this GameObject gameObject, Tag tag)
        {
            if (gameObject.TryGetComponent<Tags>(out var tags))
            {
                tags.AddTag(tag);
            }
        }
    }   
}