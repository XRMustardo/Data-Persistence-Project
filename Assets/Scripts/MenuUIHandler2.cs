using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
public class MenuUIHandler2 : MonoBehaviour

{

    public Text DisplayPlayerName;

    public void Awake()
    {
        DisplayPlayerName.text = PlayerDataHandler.Instance.PlayerName;
    }

}

