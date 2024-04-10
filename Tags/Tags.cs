using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace InnScripts
{
    public class Tags:MonoBehaviour
    {
        [field: SerializeField]
        private List<Tag> _tags;
        public List<Tag> All => _tags;

        public bool HasTag(Tag tag)
        {
            return _tags.Contains(tag);
        }
        public bool HasTag(string tagName)
        {
            return _tags.Exists(tag => tag.Name.ToLower() == tagName.ToLower());
        }
        public void AddTag(Tag tag)
        {
            if (!HasTag(tag))
                _tags.Add(tag);
        }
        public void Remove(Tag tag)
        {
            if (HasTag(tag))
                _tags.Remove(tag);
        } 
        public void AddTag(string tagName)
        {
            if (!HasTag(tagName))
            {
                Tag tag = new Tag();
                tag.name = tagName;
                _tags.Add(tag);
            }
        }
        public void Remove(string tagName)
        {
            if (HasTag(tagName))
            {
                Tag tag = _tags.Find(tag => tag.Name.ToLower() == tagName.ToLower());
                _tags.Remove(tag);
            }
        }
        public void RemoveAll()
        {
            List<Tag> _tags = All.ToList();
            foreach (Tag tag in _tags)
            {
                Remove(tag);
            }

            
        }
    }
}
