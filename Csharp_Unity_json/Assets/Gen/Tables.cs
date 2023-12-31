//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using SimpleJSON;


namespace cfg
{ 
   
public sealed partial class Tables
{
    public item.TbItem TbItem {get; }
    public demo.TbReward TbReward {get; }

    public Tables(System.Func<string, JSONNode> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        //item_tbitem是这json文件的文件名，好像是它内部设置提取的。
        TbItem = new item.TbItem(loader("item_tbitem")); 
        tables.Add("item.TbItem", TbItem);
        TbReward = new demo.TbReward(loader("demo_tbreward")); 
        tables.Add("demo.TbReward", TbReward);
        PostInit();

        TbItem.Resolve(tables); 
        TbReward.Resolve(tables); 
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbItem.TranslateText(translator); 
        TbReward.TranslateText(translator); 
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}