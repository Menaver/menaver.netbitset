﻿using BenchmarkDotNet.Attributes;

namespace Menaver.NetBitSet.Tests.Perf.Bitwise;

public class NetBitSetBitwiseAndOrXorPerfTestSuit : PerfTestSuitBase
{
    private NetBitSet _netBitSetA = null!;
    private NetBitSet _netBitSetB = null!;

    // 1 kbit, 1 Mbit, 10 Mbit
    [Params(8192, 8388608, 83886080)] public ulong BitCount;

    [IterationSetup]
    public void Setup()
    {
        _netBitSetA = BuildRandomNetBitSet(BitCount);
        _netBitSetB = BuildRandomNetBitSet(BitCount);
    }

    [Benchmark]
    public void And()
    {
        _netBitSetA.And(_netBitSetB);
    }

    [Benchmark]
    public void Or()
    {
        _netBitSetA.Or(_netBitSetB);
    }

    [Benchmark]
    public void Xor()
    {
        _netBitSetA.Xor(_netBitSetB);
    }
}