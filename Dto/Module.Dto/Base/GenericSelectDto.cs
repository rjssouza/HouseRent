using System;

namespace Module.Dto.Base
{
    [Serializable]
    public abstract class BaseGenericSelectDto<T>
    {
        public virtual string Text { get; set; }

        public virtual T Value { get; set; }
    }

    [Serializable]
    public class GenericSelectDto : BaseGenericSelectDto<string>
    {
    }

    [Serializable]
    public class GenericSelectDto<T> : BaseGenericSelectDto<T>
    {
    }
}