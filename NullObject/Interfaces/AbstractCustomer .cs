using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Interfaces
{
    public interface ICustomer {
        string DisplayName { get; }
        bool IsNil { get; }
    }
    public abstract class AbstractCustomer : ICustomer{
        private readonly string _displayName;
        public AbstractCustomer(string displayName)
        {
            this._displayName = displayName;
        }
        public virtual string DisplayName
        {
            get { return this._displayName; }
        }

        public virtual bool IsNil
        {
            get { return false; }
        }
    }
}
