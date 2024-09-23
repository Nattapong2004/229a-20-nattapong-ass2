using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    //ตั้ง name,health,speed,hanger ตามที่โจตย์บอก
    private void Start()
    {
        Init("Dog", 10, 3f, 0, "Meat");
    }

    private string breed;


    public string Breed
    {get { return breed; }
        set { breed = value; }

     }
        
        

    public void Fetch()
    {
        Debug.Log($"{name} fetch");
    }
}
