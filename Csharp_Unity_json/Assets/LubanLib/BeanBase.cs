using Bright.Serialization;
using UnityEngine;

namespace Bright.Config
{
    public abstract class BeanBase : ScriptableObject,ITypeId
    {
        public abstract int GetTypeId();
    }
}
