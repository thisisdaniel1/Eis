using UnityEngine;

// all future dialogue nodes inherit from here
public abstract class DialogueNode : ScriptableObject
{
    [SerializeField]
    private NarrationLine m_DialogueLine;

    public NarrationLine DialogueLine => m_DialogueLine;

    public abstract bool CanBeFollowedByNode(DialogueNode node);
    public abstract void Accept(DialogueNodeVisitor visitor);
}
