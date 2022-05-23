using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{

    // guarda el int
    public void SetInt(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
        PlayerPrefs.Save();
    }

    // guarda el float
    public void SetFloat(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
        PlayerPrefs.Save();
    }

    // guarda el string
    public void SetString(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
    }

    // guarda el bool
    public void SetBool(string key, bool value)
    {
        PlayerPrefs.SetString(key, value.ToString());
        PlayerPrefs.Save();
    }


    // devuelve un int
    public int GetInt(string key)
    {
        return PlayerPrefs.GetInt(key);
    }

    // devuelve un float
    public float GetFloat(string key)
    {
        return PlayerPrefs.GetFloat(key);
    }

    // devuelve un string
    public bool GetBool(string key)
    {
        return bool.Parse(PlayerPrefs.GetString(key));
    }

    // devuelve un bool
    public string GetString(string key)
    {
        return PlayerPrefs.GetString(key);
    }

    // comprueba si hay un valor con una key
    public bool HasKey(string key)
    {
        return PlayerPrefs.HasKey(key);
    }

    // elimina los valores
    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
}