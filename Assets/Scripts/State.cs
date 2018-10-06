using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject  {

    [TextArea(10,14)] [SerializeField] string storyText;
    [TextArea(2, 4)] [SerializeField] string actionText;
    [SerializeField] Sprite image;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public string GetStateActions()
    {
        return actionText;
    }

    public Sprite GetStateSprite()
    {
        return image;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
