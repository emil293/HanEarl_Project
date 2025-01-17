using System;
using System.Collections.Generic;
[Serializable]
public class JItemData : JData 
{
    public List<JItemInstance> itemList = new List<JItemInstance>();
}

[Serializable]
public class JItemInstance
{
    // 고정 값
    public string itemName;
    public int index;

    // 변하는 값
    public bool isGet;
    public bool isInvn; // 인벤토리에 존재하는지
}