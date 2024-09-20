using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Cat Cat;
    [SerializeField] Dog Dog;
    [SerializeField] Rabbit Rabbit;

    // Start is called before the first frame update
    void Start()
    {
        //แสดง name,health,speed,hunger ของสัตว์แต่ล่ะตัว
        Debug.Log($"{Cat.name} has health: {Cat.Health},speed: {Cat.Speed},Hugger: {Cat.Hunger}");
        Debug.Log($"{Dog.name} has health: {Dog.Health},speed: {Dog.Speed},Hugger: {Dog.Hunger}");
        Debug.Log($"{Rabbit.name} has health: {Rabbit.Health},speed: {Rabbit.Speed},Hugger: {Rabbit.Hunger}");

        //พฤติกรรมของแมว
        Cat.Eat();
        Cat.Move();
        Cat.Sleep();
        Cat.Climb();
        Cat.Hunger =+ 20;


        //พฤติกรรมของหมา
        Dog.Eat();
        Dog.Move();
        Dog.Sleep();
        Dog.Fetch();
        Dog.Hunger = +20;

        //พฤติกรรมของกระต่าย
        Rabbit.Eat();
        Rabbit.Move();
        Rabbit.Sleep();
        Rabbit.Hunger = +20;

        Debug.Log($"{Cat.name} has health: {Cat.Health},speed: {Cat.Speed},Hugger: {Cat.Hunger}");
        Debug.Log($"{Dog.name} has health: {Dog.Health},speed: {Dog.Speed},Hugger: {Dog.Hunger}");
        Debug.Log($"{Rabbit.name} has health: {Rabbit.Health},speed: {Rabbit.Speed},Hugger: {Rabbit.Hunger}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
