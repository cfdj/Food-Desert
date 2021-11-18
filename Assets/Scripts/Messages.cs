using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Messages", menuName = "ScriptableObject/Message")]
public class Messages : ScriptableObject

{
    public string sender;
    public string messageContent;
    public Messages reply;
    public Messages ignore;
    public int replyDay;
    public int ignoreDay;

}
