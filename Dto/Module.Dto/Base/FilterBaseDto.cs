using System;

namespace Module.Dto.Base
{
    public abstract class FilterBaseDto : FilterLimitBaseDto
    {
        public Guid? Id { get; set; }
    }

    [Serializable]
    public abstract class FilterLimitBaseDto
    {
        public string Keyword { get; set; }

        public int? LimitMax { get; set; }

        public bool LimitMustBeUsed
        {
            get
            {
                bool _limitMustBeUsed = this.LimitMax.HasValue && this.LimitStart.HasValue;

                return _limitMustBeUsed;
            }
        }

        public int? LimitStart { get; set; }
    }
}