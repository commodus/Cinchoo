namespace eSquare.Core.Attributes
{
    #region NameSpaces

    using System;
    using System.Text;
    using System.Collections.Generic;

    #endregion NameSpaces

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ChoAppDomainUnloadableAttribute : Attribute
    {
        public ChoAppDomainUnloadableAttribute()
        {
        }
    }
}