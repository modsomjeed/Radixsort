﻿namespace MyStack
{
    public interface Stack
    {
        bool isEmpty();
        int size();
        void push(object e);
        object peek();
        object pop();
    }
}
