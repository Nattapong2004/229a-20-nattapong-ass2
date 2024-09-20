using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{
    //ตั้ง name,health,speed,hanger ตามที่โจตย์บอก
    private void Start()
    {
        Init("Rabbit", 10, 3f, 0,"Plant");
    }

}
