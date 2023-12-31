//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.demo
{ 

public sealed partial class TbReward
{
    private readonly Dictionary<int, demo.Reward> _dataMap;
    private readonly List<demo.Reward> _dataList;
    
    public TbReward(JSONNode _json)
    {
        _dataMap = new Dictionary<int, demo.Reward>();
        _dataList = new List<demo.Reward>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = demo.Reward.DeserializeReward(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, demo.Reward> DataMap => _dataMap;
    public List<demo.Reward> DataList => _dataList;

    public demo.Reward GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public demo.Reward Get(int key) => _dataMap[key];
    public demo.Reward this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}