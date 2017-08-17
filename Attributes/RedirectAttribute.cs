using System;

namespace NaturalResourcesBrush.RedirectionFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RedirectAttribute : Attribute
    {
        protected RedirectAttribute(bool onCreated = false)
        {
            OnCreated = onCreated;
        }

        public bool OnCreated { get; }
    }
}