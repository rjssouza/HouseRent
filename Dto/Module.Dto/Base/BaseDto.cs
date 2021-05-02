using System;
using System.ComponentModel;

namespace Module.Dto.Base
{
    [Serializable]
    public class BaseDto
    {
        [Description("Identificador da entidade")]
        public Guid Id { get; set; }
    }
}