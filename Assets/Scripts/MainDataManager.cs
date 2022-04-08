using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDataManager : MonoBehaviour
{
    private string input;

    public static MainDataManager Instance; 

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        if (Instance!= null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input); 
    }
}
