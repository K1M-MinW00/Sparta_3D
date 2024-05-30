using UnityEngine;

public class UICondition : MonoBehaviour
{
    public Condition health;
    public Condition hunger;
    public Condition carrots;

    private void Start()
    {
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}