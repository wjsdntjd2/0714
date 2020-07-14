using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mng : MonoBehaviour
{
    #region SingleTon
    // Start is called before the first frame update
    private static Mng Instance;
    public static Mng Ins
    {
        get
        {
            if (Instance == null)
            {
                Instance = FindObjectOfType<Mng>();
                if (Instance == null)
                {
                    GameObject MngGame = new GameObject();
                    Instance = MngGame.AddComponent<Mng>();
                    MngGame.name = "GameMng";
                }
            }
            return Instance;
        }
    }
    #endregion
    public box box;
    public hero hero;
}
