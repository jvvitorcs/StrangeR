using UnityEngine;

public class MusicsPlayer : MonoBehaviour
{
    public static MusicsPlayer instance = null;
  
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void DestroyThis()
    {
        Destroy(gameObject);
    }
    
}