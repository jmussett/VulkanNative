using System.Collections;
using System.Runtime.CompilerServices;

namespace VulkanNative.Examples.Common.Utility;

public unsafe sealed class UnmanagedUtf8StringArray : UnmanagedJaggedArray<byte>, IEnumerable<UnmanagedUtf8StringSegment>
{
    public UnmanagedUtf8StringArray(int initialCapacity = 4) : base(initialCapacity)
    {
    }

    public UnmanagedUtf8StringArray(string[] items) : base(items.Length)
    {
        for(var i = 0; i < items.Length; i++)
        {
            Add(items[i]);
        }
    }

    public new UnmanagedUtf8StringSegment this[int i]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(AsPointer()[i], base[i].Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Add(in ReadOnlySpan<char> item)
    {
        Add(new UnmanagedEncodedString(item));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Add(char* chars, int length)
    {
        Add(new UnmanagedEncodedString(chars, length));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new UnmanagedUtf8StringArrayEnumerator GetEnumerator()
    {
        CheckDisposed();

        return new UnmanagedUtf8StringArrayEnumerator(_pointers, _lengths, _currentLength);
    }

    IEnumerator<UnmanagedUtf8StringSegment> IEnumerable<UnmanagedUtf8StringSegment>.GetEnumerator()
    {
        CheckDisposed();

        return new UnmanagedUtf8StringArrayEnumerator(_pointers, _lengths, _currentLength);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        CheckDisposed();

        return new UnmanagedUtf8StringArrayEnumerator(_pointers, _lengths, _currentLength);
    }

    public static implicit operator UnmanagedUtf8StringArray(string[] items) => new(items);

    public struct UnmanagedUtf8StringArrayEnumerator : IEnumerator<UnmanagedUtf8StringSegment>
    {
        private readonly byte** _pointers;
        private readonly int* _lengths;
        private readonly int _currentLength;
        private int _currentIndex;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UnmanagedUtf8StringArrayEnumerator(byte** pointers, int* lengths, int currentLength)
        {
            _pointers = pointers;
            _lengths = lengths;
            _currentLength = currentLength;
            _currentIndex = -1;
        }

        public UnmanagedUtf8StringSegment Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (_currentIndex < 0 || _currentIndex >= _currentLength)
                {
                    throw new InvalidOperationException("Index does not match size of the array.");
                }

                return new UnmanagedUtf8StringSegment(_pointers[_currentIndex], _lengths[_currentIndex]);
            }
        }

        object IEnumerator.Current => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++_currentIndex < _currentLength;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose() { }
    }
}
