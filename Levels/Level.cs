
using UnityEngine;

public abstract class Level : MonoBehaviour
{  
    [field: SerializeField]    public int level { get; private set;}

    protected virtual void PreUpgrade()
    {

    }

    //public void Upgrate(int newLevel)
    //{
    //    if (newLevel > level)
    //    {
    //        PreUpgrade();

    //        level = Mathf.Clamp(newLevel, level, Maxlevel);

    //        if (newLevel <= Maxlevel)
    //            PostUpgrade();
    //    }
    //}

    protected virtual void PostUpgrade()
    {

    }

}
