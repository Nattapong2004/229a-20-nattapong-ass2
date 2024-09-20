using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    //ตั้ง name,health,speed,hanger ตามที่โจตย์บอก
    private void Start()
    {
        Init("Cat", 10, 3f, 0,"Meat");
    }

    //พฤติกรรมเฉพาะของแมวไม่มีในตัวอื่น
    public void Climb()
    {
        Debug.Log($"{name} climb");
    }
}
