using UnityEngine;

public static class SaveProgress
{
    private const string c_Money = "Money";
    
    public static int Money
    {
        get => PlayerPrefs.GetInt(c_Money);
        set => PlayerPrefs.SetInt(c_Money, value);
    }
}