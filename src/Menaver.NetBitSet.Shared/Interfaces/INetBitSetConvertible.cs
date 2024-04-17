﻿namespace Menaver.NetBitSet.Shared.Interfaces;

/// <summary>
///     Represents an abstraction of a convertible bit-level data structure.
/// </summary>
public interface INetBitSetConvertible
{
    bool[] ToBools();
    sbyte[] ToSBytes();
    byte[] ToBytes();
    short[] ToShorts();
    ushort[] ToUShorts();
    int[] ToInts();
    uint[] ToUInts();
    long[] ToLongs();
    ulong[] ToULongs();
    double[] ToDoubles();

    string[] ToStringsByWord();

    T ToObject<T>();
}