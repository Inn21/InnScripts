using UnityEngine;

public static class Save_Load 
{ 

    public static void Clear()
    {
        PlayerPrefs.DeleteAll();
        
        #if UNITY_EDITOR
        
        Debug.Log("!!!All Deleted!!!");
        
        #endif
    }

    public static int LoadInt(string key)
    {
        int res = 0;
                
        res = PlayerPrefs.GetInt(key);

        #if UNITY_EDITOR

        Debug.Log(key + " - Loaded! V:" + res);

        #endif       

        return res;
    }
    public static float LoadFloat(string key)
    {
        float res = 0;

        if (PlayerPrefs.HasKey(key))
        {
            res = PlayerPrefs.GetFloat(key);

            #if UNITY_EDITOR

            Debug.Log(key + " - Loaded! V:" + res);

            #endif
        }

        return res;
    }
    public static string LoadString(string key)
    {
        string res = "";

        if (PlayerPrefs.HasKey(key))
        {
            res = PlayerPrefs.GetString(key);

            #if UNITY_EDITOR
                Debug.Log(key + " - Loaded! V:" + res);
            #endif      
        }

        return res;
    }public static ulong LoadULong(string key)
    {
        ulong res = 0;

        if (PlayerPrefs.HasKey(key))
        {
            res = ulong.Parse(PlayerPrefs.GetString(key));

            #if UNITY_EDITOR
                Debug.Log(key + " - Loaded! V:" + res);
            #endif      


        }

        return res;
    }


    public static bool TryToLoad(string key)
    {
#if UNITY_EDITOR
        if (PlayerPrefs.HasKey(key))
        {
            Debug.Log(key + " Can Be Loaded");
        }
        else
        {
            Debug.Log(key + " Can`t Be Loaded");
        }
#endif

        return PlayerPrefs.HasKey(key);
    }


    public static void Save(float value,string key)
    {
        #if UNITY_EDITOR
            Debug.Log(key+ " - Saved! V:" + value);
        #endif
        PlayerPrefs.SetFloat(key,value);
        PlayerPrefs.Save();
    }
    public static void Save(int value, string key)
    {
        #if UNITY_EDITOR
            Debug.Log(key + " - Saved! V:" + value);
        #endif
        PlayerPrefs.SetInt(key, value);

        PlayerPrefs.Save();
    }public static void Save(ulong value, string key)
    {
        #if UNITY_EDITOR
            Debug.Log(key + " - Saved! V:" + value);
        #endif
        PlayerPrefs.SetString(key, value.ToString());

        PlayerPrefs.Save();
    }
    public static void Save(string value, string key)
    {
        #if UNITY_EDITOR
            Debug.Log(key + " - Saved! V:" + value);
        #endif

        PlayerPrefs.SetString(key, value);

        PlayerPrefs.Save();
    }
    
}
