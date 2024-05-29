using System;
using UnityEngine;


public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }
    Condition hunger { get { return uiCondition.hunger; } }
    Condition carrots { get { return uiCondition.carrots; } }

    public float noHungerHealthDecay;
    public event Action<float> onBuff;

    private void Update()
    {
        hunger.Subtract(hunger.decayRate * Time.deltaTime);
        

        if (hunger.curValue == 0.0f)
        {
            health.Subtract(noHungerHealthDecay * Time.deltaTime);
        }

        if (health.curValue == 0.0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Eat(float amount)
    {
        hunger.Add(amount);
    }

    public void Die()
    {
        Debug.Log("플레이어가 죽었다.");
    }

    public void Pick()
    {
        carrots.Add(1f);
    }

    public void Drop()
    {
        carrots.Subtract(1f);
    }
}