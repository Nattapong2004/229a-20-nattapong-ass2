
using UnityEngine;

public class Animal : MonoBehaviour
{
    //ประกาศตัวแปร
    private string _name;
    private int health;
    protected string food ;
    private float hunger;
    private float speed;

    //get/set
    public string Name
    {
        get { return _name; }

        set { name = value; }
    }    
    public int  Health
    {
        get { return health; }

        set { health = value; }
    }
    public float Speed
    {
        get { return speed; }

        private set { speed = value; }
    }

    public float Hunger
    {
        get { return hunger; }

        set
        {
            hunger = value;
        }
    }

    public void Init(string newName,int newHealth,float newSpeed,float newHunger,string newFood)
    {
        name = newName;
        health = newHealth;
        speed = newSpeed;
        hunger = newHunger;
        food = newFood;

    }

    //พฤติกรรมของสัตว์ทุกตัว
    public void Eat()
    {
        Debug.Log($"{name} eat {food}");
    }

    public void Move()
    {
        Debug.Log($"{name} move");
    }

    public void Sleep()
    {
        Debug.Log($"{name} sleep");
    }
}
