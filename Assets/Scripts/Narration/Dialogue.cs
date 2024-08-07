using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Dialogue/Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField]
    private DialogueNode m_FirstNode;

    public DialogueNode FirstNode => m_FirstNode;
}
