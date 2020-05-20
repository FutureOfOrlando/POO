using System;
namespace Cola 
{
    public class Cola<T>
    {
    readonly int m_Size;
    int m_StackPointer = 0;
    T[] m_Items;
    public Cola():this(3)
    {}
    public Cola(int size)
    {
        m_Size = size;
        m_Items = new T[m_Size];
    }
    public void Push(T item)
    {
        if(m_StackPointer>= m_Size)
            throw new StackOverflowException();
        
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
    }
    public T Pop(){
        this.m_StackPointer--;
        if(m_StackPointer>= 0){
            var C = m_Items[0];
            for(int i = 0;i<m_StackPointer;i++)
                m_Items[i] = m_Items[i+1];
            return C;
            
        }
        else
            m_StackPointer = 0;
            throw new InvalidOperationException("Cannot pop an empty stack");
    }
}
    class Program{
         static void Main(string[] args){
            var L = new Cola<int>();
            for(int i = 0; i<3; i++){
                L.Push(i+1);}
            for(int i = 0; i<3; i++)
                Console.Write(L.Pop());
                Console.WriteLine();
                var N = new Char[]{'A','B','C'};
                var text = new Cola<char>(N.Length);
            for(int i = 0; i<N.Length; i++)
                text.Push(N[i]);
            for(int i = 0; i<N.Length; i++)
                Console.Write(text.Pop());
         }
    }
}