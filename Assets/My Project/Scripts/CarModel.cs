using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Car Modell", menuName = "Car")]
public class CarModel : ScriptableObject
{
    public string Name;
    public string Model;
    public float TopSpeed;
    public string BHP;

    public enum Performance {  Tier1, Tier2, Tier3 };
    public Performance perfType;

    public enum Handling { easy, normal, expert, challenging};
    public Handling handing;

    public GameObject car;

    public string GetTopSpeed()
    {
        return TopSpeed + "KM/H";
    }
}
