namespace Composite.Core.Types
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public sealed class ExtendedNullable<T>
    {
        private T _value = default(T);
        private bool _hasValue = false;


        /// <exclude />
        public static implicit operator ExtendedNullable<T>(T value)
        {
            ExtendedNullable<T> extendedNullable = new ExtendedNullable<T>();

            extendedNullable.Value = value;

            return extendedNullable;
        }


        /// <exclude />
        public bool HasValue
        {
            get
            {
                return _hasValue;
            }
        }


        /// <exclude />
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                SetValue(value);
            }
        }


        private void SetValue(T value)
        {
            _value = value;
            _hasValue = true;
        }
    }
}
