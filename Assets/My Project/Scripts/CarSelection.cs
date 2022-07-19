using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarSelection : MonoBehaviour
{
    public CarModel[] carmodels;
    public Transform spot;

    public TextMeshProUGUI title;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI tier;

    private List<GameObject> cars;
    private int currentCar;

    private void Awake()
    {
        title = title.GetComponent<TextMeshProUGUI>();
        speed = speed.GetComponent<TextMeshProUGUI>();
        tier = tier.GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        cars = new List<GameObject>();

        foreach(var carModel in carmodels)
        {
            GameObject go = Instantiate(carModel.car,
                spot.position, Quaternion.identity);
            go.SetActive(false);
            go.transform.SetParent(spot);
            cars.Add(go);
        }
        ShowCarFromList();
    }

    void ShowCarFromList()
    {
        cars[currentCar].SetActive(true);
        title.text = carmodels[currentCar].name;
        speed.text = carmodels[currentCar].GetTopSpeed();
        tier.text = carmodels[currentCar].perfType.ToString();
    }

    public void OnClickNext()
    {
        cars[currentCar].SetActive(false);

        if(currentCar < cars.Count - 1)
        {
            ++currentCar;
        }
        else
        {
            currentCar = 0;
        }
        ShowCarFromList();
    }

    public void OnClickPrev()
    {
        cars[currentCar].SetActive(false);

        if (currentCar == 0)
        {
            currentCar = cars.Count - 1;
        }
        else
        {
            --currentCar;
        }
        ShowCarFromList();
    }
}
